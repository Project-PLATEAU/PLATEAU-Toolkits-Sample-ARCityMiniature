using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

static class MeshUtilitiesEditor
{
    [MenuItem("Miniature Viewer/選択階層配下の表示されているメッシュレンダラーを選択")]
    public static void SelectVisibleMeshRenderersMenu()
    {
        SelectVisibleMeshRenderers();
    }

    [MenuItem("Miniature Viewer/選択地物を原点に整列")]
    public static void AlignEachBottomToOriginMenu()
    {
        AlignEachBottomToOrigin();
    }

    [MenuItem("Miniature Viewer/選択したメッシュの結合")]
    public static void CombineSelectedMeshesMenu()
    {
        GameObject[] selectedObjects = Selection.gameObjects;
        if (selectedObjects.Length == 0)
        {
            EditorUtility.DisplayDialog("Error", "ゲームオブジェクトが選択されていません", "OK");
            return;
        }

        GameObject combinedMeshObject = CombineSelectedMeshes(selectedObjects);
        if (combinedMeshObject != null)
        {
            Selection.activeGameObject = combinedMeshObject;
        }
    }

    public static void SelectVisibleMeshRenderers()
    {
        GameObject[] selectedObjects = Selection.gameObjects;
        if (selectedObjects == null || selectedObjects.Length == 0)
        {
            EditorUtility.DisplayDialog("Error", "ゲームオブジェクトが選択されていません.", "OK");
            return;
        }

        var visibleMeshRenderers = new List<GameObject>();
        foreach (GameObject obj in selectedObjects)
        {
            CollectVisibleMeshRenderers(obj.transform, visibleMeshRenderers);
        }

        Selection.objects = visibleMeshRenderers.ToArray();
    }

    static void CollectVisibleMeshRenderers(Transform parent, List<GameObject> visibleMeshRenderers)
    {
        foreach (Transform child in parent)
        {
            MeshRenderer meshRenderer = child.GetComponent<MeshRenderer>();
            if (meshRenderer != null && meshRenderer.enabled)
            {
                visibleMeshRenderers.Add(child.gameObject);
            }

            CollectVisibleMeshRenderers(child, visibleMeshRenderers);
        }
    }

    public static GameObject CombineSelectedMeshes(GameObject[] selectedObjects)
    {
        List<MeshFilter> meshFilters = new List<MeshFilter>();
        List<MeshRenderer> meshRenderers = new List<MeshRenderer>();

        foreach (GameObject obj in selectedObjects)
        {
            MeshFilter meshFilter = obj.GetComponent<MeshFilter>();
            MeshRenderer meshRenderer = obj.GetComponent<MeshRenderer>();

            if (meshFilter != null && meshRenderer != null)
            {
                meshFilters.Add(meshFilter);
                meshRenderers.Add(meshRenderer);
            }
        }

        if (meshFilters.Count == 0 || meshRenderers.Count == 0)
        {
            Debug.LogError("選択したオブジェクトに MeshFiltersコンポーネント または MeshRendererコンポーネント が見つかりません。");
            return null;
        }

        return CombineMeshes(meshFilters, meshRenderers);
    }

    static void CollectMeshComponents(Transform parentTransform, List<MeshFilter> meshFilters, List<MeshRenderer> meshRenderers)
    {
        foreach (Transform child in parentTransform)
        {
            MeshFilter meshFilter = child.GetComponent<MeshFilter>();
            MeshRenderer meshRenderer = child.GetComponent<MeshRenderer>();
            if (meshFilter != null && meshRenderer != null)
            {
                meshFilters.Add(meshFilter);
                meshRenderers.Add(meshRenderer);
            }

            CollectMeshComponents(child, meshFilters, meshRenderers);
        }
    }

    public static GameObject CombineMeshes(List<MeshFilter> meshFilters, List<MeshRenderer> meshRenderers)
    {
        GameObject combinedMeshObject = new GameObject("CombinedMesh");
        Undo.RegisterCreatedObjectUndo(combinedMeshObject, "Combine Meshes");
        MeshFilter combinedMeshFilter = combinedMeshObject.AddComponent<MeshFilter>();
        MeshRenderer combinedMeshRenderer = combinedMeshObject.AddComponent<MeshRenderer>();

        var materialToMeshFilters = new Dictionary<Material, List<MeshFilter>>();
        for (int i = 0; i < meshFilters.Count; i++)
        {
            Material material = meshRenderers[i].sharedMaterial;
            if (!materialToMeshFilters.ContainsKey(material))
            {
                materialToMeshFilters[material] = new List<MeshFilter>();
            }
            materialToMeshFilters[material].Add(meshFilters[i]);
        }

        CombineInstance[] combineInstances = materialToMeshFilters.SelectMany(pair =>
            pair.Value.Select(meshFilter => new CombineInstance
            {
                mesh = meshFilter.sharedMesh,
                transform = meshFilter.transform.localToWorldMatrix
            })).ToArray();

        Mesh combinedMesh = new Mesh();
        combinedMesh.CombineMeshes(combineInstances, true, true);
        combinedMeshFilter.sharedMesh = combinedMesh;

        combinedMeshRenderer.materials = materialToMeshFilters.Keys.ToArray();

        return combinedMeshObject;
    }

    public static void AlignEachBottomToOrigin()
    {
        GameObject[] selectedObjects = Selection.gameObjects;
        if (selectedObjects == null || selectedObjects.Length == 0)
        {
            EditorUtility.DisplayDialog("エラー", "ゲームオブジェクトが選択されていません", "閉じる");
            return;
        }

        Undo.SetCurrentGroupName("Align Bottoms to Origin");
        int undoGroup = Undo.GetCurrentGroup();

        foreach (GameObject obj in selectedObjects)
        {
            AlignBottomToOrigin(obj);
        }

        Undo.CollapseUndoOperations(undoGroup);
    }

    public static void AlignBottomToOrigin(GameObject obj)
    {
        MeshRenderer meshRenderer = obj.GetComponent<MeshRenderer>();
        if (meshRenderer)
        {
            Bounds bounds = meshRenderer.bounds;
            float yOffset = bounds.min.y;

            Undo.RecordObject(obj.transform, "Align Bottom to Origin");

            Vector3 position = obj.transform.position;
            position.y -= yOffset;
            obj.transform.position = position;
        }
    }
}
