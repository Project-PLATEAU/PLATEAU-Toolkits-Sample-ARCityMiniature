using UnityEngine;

namespace PlateauSamples.MiniatureViewer
{
    public class ResolutionScaling : MonoBehaviour
    {
        void Start()
        {
            float scalingFactor = CalculateScalingFactor();
            QualitySettings.resolutionScalingFixedDPIFactor = scalingFactor;
        }

        float CalculateScalingFactor()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                if (SystemInfo.systemMemorySize > 5000)
                {
                    return 1.0f;
                }
                else if (SystemInfo.systemMemorySize > 3500)
                {
                    return 0.7f;
                }
            }
            else
            {
                if (SystemInfo.systemMemorySize > 5000)
                {
                    return 0.7f;
                }
            }

            return 0.5f;
        }
    }
}
