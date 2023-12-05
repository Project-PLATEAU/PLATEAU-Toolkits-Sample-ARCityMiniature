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

            // �{�^����ǉ�
            if (GUILayout.Button("Start Animation"))
            {
                script.StartAnimation();
            }

            // Alpha �l�̃X���C�_�[
            GUILayout.Label("Set Alpha Value");
            alphaValue = EditorGUILayout.Slider("Alpha", alphaValue, 0f, 1f);
            if (GUILayout.Button("Set Alpha"))
            {
                script.SetAlpha(alphaValue);
            }

            // Dissolve �l�̃X���C�_�[
            GUILayout.Label("Set Dissolve Value");
            dissolveValue = EditorGUILayout.Slider("Dissolve", dissolveValue, -1f, 1f);
            if (GUILayout.Button("Set Dissolve"))
            {
                script.SetDissolve(dissolveValue);
            }
        }

    }
}
