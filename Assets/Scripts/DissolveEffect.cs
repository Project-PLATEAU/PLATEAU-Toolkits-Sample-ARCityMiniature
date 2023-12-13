using UnityEngine;

namespace PlateauSamples.MiniatureViewer
{
    public class DissolveEffect : MonoBehaviour
    {
        [SerializeField] Material[] m_DissolveMaterials; // Reference to the dissolve materials array
        [SerializeField] float m_DissolveTime = 5.0f; // Time (in seconds) for the animation to complete
        [SerializeField] AnimationCurve m_DissolveCurve; // Animation curve for the dissolve parameter
        [SerializeField] AnimationCurve m_AlphaCurve; // Animation curve for the alpha parameter
        [SerializeField] bool m_LoopAnimation; // Whether to enable loop animation

        float m_CurrentTime; // Current time
        bool m_IsAnimating; // Whether the animation is in progress
        static readonly int k_Dissolve = Shader.PropertyToID("_Dissolve");
        static readonly int k_GlobalOpacity = Shader.PropertyToID("_GlobalOpacity");

        void Start()
        {
            Shader.SetGlobalFloat(k_GlobalOpacity, 0);
            foreach (Material material in m_DissolveMaterials)
            {
                if (material != null)
                {
                    material.SetFloat(k_Dissolve, 1.5f);
                }
            }

            Invoke(nameof(StartAnimation), 1.0f); // Set to 1 seconds here
        }

        void Update()
        {
            if (m_IsAnimating)
            {
                m_CurrentTime += Time.deltaTime;

                if (m_CurrentTime > m_DissolveTime)
                {
                    if (m_LoopAnimation)
                    {
                        m_CurrentTime = 0.0f; // Reset time for loop
                    }
                    else
                    {
                        m_CurrentTime = m_DissolveTime;
                        m_IsAnimating = false; // Animation complete
                    }
                }

                float dissolveValue = m_DissolveCurve.Evaluate(m_CurrentTime / m_DissolveTime);
                float alphaValue = m_AlphaCurve.Evaluate(m_CurrentTime / m_DissolveTime);

                foreach (Material material in m_DissolveMaterials)
                {
                    if (material != null)
                    {
                        material.SetFloat(k_Dissolve, dissolveValue);
                    }
                }
                Shader.SetGlobalFloat(k_GlobalOpacity, alphaValue);
            }
        }

        public void StartAnimation()
        {
            m_CurrentTime = 0.0f;
            m_IsAnimating = true;
        }

        public void SetAlpha(float alpha)
        {
            Shader.SetGlobalFloat(k_GlobalOpacity, alpha);
        }

        public void SetDissolve(float dissolve)
        {
            foreach (Material material in m_DissolveMaterials)
            {
                if (material != null)
                {
                    material.SetFloat(k_Dissolve, dissolve);
                }
            }
        }
    }
}
