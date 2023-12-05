using System;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace PlateauSamples.MiniatureViewer
{
    class MiniatureCityModels : MonoBehaviour
    {
        [Serializable]
        class MiniatureCityModel
        {
            public string m_ARMarkerName;
            public GameObject m_CityModelPrefab;
        }

        [SerializeField] MiniatureCityModel[] m_CityModels;
        [SerializeField] MiniatureCityModelUI m_CityModelUI;

        void Start()
        {
            if (!TryGetComponent(out ARTrackedImage trackedImage))
            {
                Debug.LogError($"{nameof(ARTrackedImage)} was not found");
                return;
            }

            MiniatureCityModel targetCityModel = m_CityModels
                .FirstOrDefault(m => m.m_ARMarkerName == trackedImage.referenceImage.name);

            if (targetCityModel == null)
            {
                Debug.LogError(
                    $"ARマーカーが検出されましたが、マーカー画像「{trackedImage.referenceImage.name}」に対応する3D都市モデルは登録されていません。");
                return;
            }

            GameObject cityModel = Instantiate(targetCityModel.m_CityModelPrefab, transform);
            cityModel.transform.localPosition = Vector3.zero;
            cityModel.transform.localRotation = Quaternion.identity;

            m_CityModelUI.SetCityModelTransform(cityModel.transform);
        }
    }
}
