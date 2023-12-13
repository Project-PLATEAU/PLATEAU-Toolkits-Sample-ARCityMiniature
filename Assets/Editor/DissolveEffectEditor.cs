using UnityEngine;
using UnityEditor;

namespace PlateauSamples.MiniatureViewer
{
    [CustomEditor(typeof(DissolveEffect))]
    public class DissolveEffectEditor : Editor
    {
        float m_AlphaValue = 1.0f;
        float m_DissolveValue = 0.0f;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            DissolveEffect script = (DissolveEffect)target;

            if (GUILayout.Button("Start Animation"))
            {
                script.StartAnimation();
            }

            GUILayout.Label("Set Alpha Value");
            m_AlphaValue = EditorGUILayout.Slider("Alpha", m_AlphaValue, 0f, 1f);
            if (GUILayout.Button("Set Alpha"))
            {
                script.SetAlpha(m_AlphaValue);
            }

            GUILayout.Label("Set Dissolve Value");
            m_DissolveValue = EditorGUILayout.Slider("Dissolve", m_DissolveValue, -1f, 1f);
            if (GUILayout.Button("Set Dissolve"))
            {
                script.SetDissolve(m_DissolveValue);
            }
        }
    }
}
