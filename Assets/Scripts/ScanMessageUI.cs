using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace PlateauSamples.MiniatureViewer
{
    class ScanMessageUI : MonoBehaviour
    {
        [SerializeField] ARTrackedImageManager m_ARTrackedImageManager;
        [SerializeField] GameObject m_MessageUI;

        void Update()
        {
            m_MessageUI.SetActive(m_ARTrackedImageManager.trackables.count == 0);
        }
    }
}