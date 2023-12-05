using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace PlateauSamples.MiniatureViewer
{
    [ExecuteAlways]
    public class PrefabLightmapData : MonoBehaviour
    {
        [Serializable]
        struct RendererInfo
        {
            public Renderer m_Renderer;
            public int m_LightmapIndex;
            public Vector4 m_LightmapOffsetScale;
        }

        [Serializable]
        struct LightInfo
        {
            public Light m_Light;
            public int m_LightmapBakeType;
            public int m_MixedLightingMode;
        }

        [SerializeField] RendererInfo[] m_RendererInfo;
        [SerializeField] Texture2D[] m_Lightmaps;
        [SerializeField] Texture2D[] m_LightmapsDir;
        [SerializeField] Texture2D[] m_ShadowMasks;
        [SerializeField] LightInfo[] m_LightInfo;

        void Awake()
        {
            Init();
        }

        void Init()
        {
            if (m_RendererInfo == null || m_RendererInfo.Length == 0)
            {
                return;
            }

            LightmapData[] lightmaps = LightmapSettings.lightmaps;
            int[] offsetsIndexes = new int[m_Lightmaps.Length];
            int totalCount = lightmaps.Length;
            List<LightmapData> combinedLightmaps = new();

            for (int i = 0; i < m_Lightmaps.Length; i++)
            {
                bool exists = false;
                for (int j = 0; j < lightmaps.Length; j++)
                {

                    if (m_Lightmaps[i] == lightmaps[j].lightmapColor)
                    {
                        exists = true;
                        offsetsIndexes[i] = j;

                    }
                }
                if (!exists)
                {
                    offsetsIndexes[i] = totalCount;
                    LightmapData newLightmapData = new()
                    {
                        lightmapColor = m_Lightmaps[i],
                        lightmapDir = m_LightmapsDir.Length == m_Lightmaps.Length ? m_LightmapsDir[i] : default(Texture2D),
                        shadowMask = m_ShadowMasks.Length == m_Lightmaps.Length ? m_ShadowMasks[i] : default(Texture2D),
                    };

                    combinedLightmaps.Add(newLightmapData);

                    totalCount += 1;

                }
            }

            var combinedLightmaps2 = new LightmapData[totalCount];

            lightmaps.CopyTo(combinedLightmaps2, 0);
            combinedLightmaps.ToArray().CopyTo(combinedLightmaps2, lightmaps.Length);

            bool directional = true;

            foreach (Texture2D t in m_LightmapsDir)
            {
                if (t == null)
                {
                    directional = false;
                    break;
                }
            }

            LightmapSettings.lightmapsMode = (m_LightmapsDir.Length == m_Lightmaps.Length && directional) ? LightmapsMode.CombinedDirectional : LightmapsMode.NonDirectional;
            ApplyRendererInfo(m_RendererInfo, offsetsIndexes, m_LightInfo);
            LightmapSettings.lightmaps = combinedLightmaps2;
        }

        void OnEnable()
        {

            SceneManager.sceneLoaded += OnSceneLoaded;

        }

        // called second
        void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            Init();
        }

        // called when the game is terminated
        void OnDisable()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }

        static void ApplyRendererInfo(RendererInfo[] infos, int[] lightmapOffsetIndex, LightInfo[] lightsInfo)
        {
            foreach (RendererInfo info in infos)
            {
                info.m_Renderer.lightmapIndex = lightmapOffsetIndex[info.m_LightmapIndex];
                info.m_Renderer.lightmapScaleOffset = info.m_LightmapOffsetScale;

                // You have to release shaders.
                foreach (Material material in info.m_Renderer.sharedMaterials)
                {
                    if (material != null && Shader.Find(material.shader.name) != null)
                    {
                        material.shader = Shader.Find(material.shader.name);
                    }
                }
            }

            for (int i = 0; i < lightsInfo.Length; i++)
            {
                LightBakingOutput bakingOutput = new()
                {
                    isBaked = true,
                    lightmapBakeType = (LightmapBakeType)lightsInfo[i].m_LightmapBakeType,
                    mixedLightingMode = (MixedLightingMode)lightsInfo[i].m_MixedLightingMode,
                };

                lightsInfo[i].m_Light.bakingOutput = bakingOutput;

            }
        }

#if UNITY_EDITOR
        [MenuItem("Miniature Viewer/シーンのライトマップをプレハブに設定")]
        static void GenerateLightmapInfo()
        {
            if (Lightmapping.giWorkflowMode != Lightmapping.GIWorkflowMode.OnDemand)
            {
                Debug.LogError("ExtractLightmapData requires that you have baked you lightmaps and Auto mode is disabled.");
                return;
            }
            Lightmapping.Bake();

            PrefabLightmapData[] prefabs = FindObjectsOfType<PrefabLightmapData>();

            foreach (PrefabLightmapData instance in prefabs)
            {
                GameObject gameObject = instance.gameObject;
                var rendererInfos = new List<RendererInfo>();
                var lightmaps = new List<Texture2D>();
                var lightmapsDir = new List<Texture2D>();
                var shadowMasks = new List<Texture2D>();
                var lightsInfos = new List<LightInfo>();

                GenerateLightmapInfo(gameObject, rendererInfos, lightmaps, lightmapsDir, shadowMasks, lightsInfos);

                instance.m_RendererInfo = rendererInfos.ToArray();
                instance.m_Lightmaps = lightmaps.ToArray();
                instance.m_LightmapsDir = lightmapsDir.ToArray();
                instance.m_LightInfo = lightsInfos.ToArray();
                instance.m_ShadowMasks = shadowMasks.ToArray();

                GameObject targetPrefab = PrefabUtility.GetCorrespondingObjectFromOriginalSource(instance.gameObject);
                if (targetPrefab != null)
                {
                    GameObject root = PrefabUtility.GetOutermostPrefabInstanceRoot(instance.gameObject);

                    if (root != null)
                    {
                        GameObject rootPrefab = PrefabUtility.GetCorrespondingObjectFromSource(instance.gameObject);
                        string rootPath = AssetDatabase.GetAssetPath(rootPrefab);

                        PrefabUtility.UnpackPrefabInstanceAndReturnNewOutermostRoots(root, PrefabUnpackMode.OutermostRoot);
                        try
                        {
                            PrefabUtility.ApplyPrefabInstance(instance.gameObject, InteractionMode.AutomatedAction);
                        }
                        catch (Exception exception)
                        {
                            Debug.LogError(exception);
                        }
                        finally
                        {
                            PrefabUtility.SaveAsPrefabAssetAndConnect(root, rootPath, InteractionMode.AutomatedAction);
                        }
                    }
                    else
                    {
                        PrefabUtility.ApplyPrefabInstance(instance.gameObject, InteractionMode.AutomatedAction);
                    }
                }
            }
        }

        static void GenerateLightmapInfo(GameObject root, List<RendererInfo> rendererInfos, List<Texture2D> lightmaps, List<Texture2D> lightmapsDir, List<Texture2D> shadowMasks, List<LightInfo> lightsInfo)
        {
            MeshRenderer[] renderers = root.GetComponentsInChildren<MeshRenderer>();
            foreach (MeshRenderer renderer in renderers)
            {
                if (renderer.lightmapIndex != -1)
                {
                    RendererInfo info = new()
                    {
                        m_Renderer = renderer
                    };

                    if (renderer.lightmapScaleOffset != Vector4.zero)
                    {
                        // 1ibrium's pointed out this issue : https://docs.unity3d.com/ScriptReference/Renderer-lightmapIndex.html
                        if (renderer.lightmapIndex < 0 || renderer.lightmapIndex == 0xFFFE)
                        {
                            continue;
                        }

                        info.m_LightmapOffsetScale = renderer.lightmapScaleOffset;

                        Texture2D lightmap = LightmapSettings.lightmaps[renderer.lightmapIndex].lightmapColor;
                        Texture2D lightmapDir = LightmapSettings.lightmaps[renderer.lightmapIndex].lightmapDir;
                        Texture2D shadowMask = LightmapSettings.lightmaps[renderer.lightmapIndex].shadowMask;

                        info.m_LightmapIndex = lightmaps.IndexOf(lightmap);
                        if (info.m_LightmapIndex == -1)
                        {
                            info.m_LightmapIndex = lightmaps.Count;
                            lightmaps.Add(lightmap);
                            lightmapsDir.Add(lightmapDir);
                            shadowMasks.Add(shadowMask);
                        }

                        rendererInfos.Add(info);
                    }
                }
            }

            Light[] lights = root.GetComponentsInChildren<Light>(true);

            foreach (Light l in lights)
            {
                LightInfo lightInfo = new()
                {
                    m_Light = l,
                    m_LightmapBakeType = (int)l.lightmapBakeType,
                    m_MixedLightingMode = (int)Lightmapping.lightingSettings.mixedBakeMode,
                };
                lightsInfo.Add(lightInfo);
            }
        }
#endif
    }
}
