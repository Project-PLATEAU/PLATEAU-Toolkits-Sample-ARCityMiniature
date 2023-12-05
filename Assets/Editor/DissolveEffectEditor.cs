using UnityEngine;
using UnityEditor;

namespace PlateauSamples.MiniatureViewer
{
    [CustomEditor(typeof(DissolveEffect))]
    public class DissolveEffectEditor : Editor
    {
        private float alphaValue = 1.0f;
        private float dissolveValue = 0.0f;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            DissolveEffect script = (DissolveEffect)target;

            // ボタンを追加
            if (GUILayout.Button("Start Animation"))
            {
                script.StartAnimation();
            }

            // Alpha 値のスライダー
            GUILayout.Label("Set Alpha Value");
            alphaValue = EditorGUILayout.Slider("Alpha", alphaValue, 0f, 1f);
            if (GUILayout.Button("Set Alpha"))
            {
                script.SetAlpha(alphaValue);
            }

            // Dissolve 値のスライダー
            GUILayout.Label("Set Dissolve Value");
            dissolveValue = EditorGUILayout.Slider("Dissolve", dissolveValue, -1f, 1f);
            if (GUILayout.Button("Set Dissolve"))
            {
                script.SetDissolve(dissolveValue);
            }
        }

    }
}
