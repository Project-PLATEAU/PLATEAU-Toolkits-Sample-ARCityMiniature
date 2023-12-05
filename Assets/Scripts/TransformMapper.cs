using UnityEngine;

namespace PlateauSamples.MiniatureViewer
{
    public class TransformMapper : MonoBehaviour
    {
        public Transform m_DummyObject;
        public Transform m_MiniatureCity;

        void Update()
        {
            if (m_DummyObject != null && m_MiniatureCity != null)
            {
                // Dummy object position adjusted to scale of miniature city
                Vector3 scaledPosition = m_DummyObject.position * 0.01f; // Adjustment for a scale of 0.01
                Vector3 newPosition = m_MiniatureCity.TransformPoint(scaledPosition);
                Quaternion newRotation = m_MiniatureCity.rotation * m_DummyObject.rotation;

                transform.position = newPosition;
                transform.rotation = newRotation;
                transform.localScale = new Vector3(1, 1, 1) * m_MiniatureCity.localScale.x; // Miniature cities are uniformly scaled
            }
        }
    }
}