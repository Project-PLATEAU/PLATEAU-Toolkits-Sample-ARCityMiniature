using UnityEngine;

namespace PlateauSamples.MiniatureViewer
{
    public class ResolutionScaling : MonoBehaviour
    {
        void Start()
        {
            if (SystemInfo.systemMemorySize < 6000)
            {
                QualitySettings.resolutionScalingFixedDPIFactor = 0.5f;
            }
        }
    }
}