using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace PlateauSamples.MiniatureViewer
{
    public class MiniatureCityUIManager : MonoBehaviour
    {
        [SerializeField] MiniatureCityModelUI m_UI;
        [SerializeField] ARTrackedImageManager m_ARTrackedImageManager;

        void Update()
        {
            m_UI.gameObject.SetActive(m_ARTrackedImageManager.trackables.count > 0);
        }
    }
}
