using UnityEngine;
using UnityEngine.UI;

namespace PlateauSamples.MiniatureViewer
{
    public class MiniatureCityModelUI : MonoBehaviour
    {
        [SerializeField] Slider m_ZoomSlider;
        [SerializeField] Slider m_RotationSlider;

        Transform m_CityModel;

        public void SetCityModelTransform(Transform cityModel)
        {
            m_CityModel = cityModel;
        }

        void Start()
        {
            m_ZoomSlider.onValueChanged.AddListener(value =>
            {
                m_CityModel.localScale = Vector3.one * value;
            });

            m_RotationSlider.onValueChanged.AddListener(value =>
            {
                m_CityModel.localRotation = Quaternion.Euler(0f, value, 0f);
            });
        }
    }
}