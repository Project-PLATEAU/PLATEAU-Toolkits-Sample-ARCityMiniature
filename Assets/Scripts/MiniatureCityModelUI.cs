using UnityEngine;
using Slider = UnityEngine.UI.Slider;

namespace PlateauSamples.MiniatureViewer
{
    public class MiniatureCityModelUI : MonoBehaviour
    {
        [SerializeField] Slider m_ZoomSlider;
        [SerializeField] Slider m_RotationSlider;
        [SerializeField] Transform m_TargetTransform;
        [SerializeField] Transform m_MarkerPoint;
        void Start()
        {
            m_ZoomSlider.onValueChanged.AddListener(value =>
            {
                m_TargetTransform.localScale = Vector3.one * value;
            });

            m_RotationSlider.onValueChanged.AddListener(value =>
            {
                m_MarkerPoint.localRotation = Quaternion.Euler(0f, value, 0f);
            });
        }
    }
}
