using UnityEngine;
using UnityEngine.UI;

namespace PlateauSamples.MiniatureViewer
{
    public class GameStarter : MonoBehaviour
    {
        [SerializeField] Button m_StartButton;
        [SerializeField] GameObject m_ARObjects;
        [SerializeField] GameObject m_StartCanvas;

        void Start()
        {
            m_StartButton.onClick.AddListener(() =>
            {
                m_ARObjects.SetActive(true);
                m_StartCanvas.SetActive(false);
            });
        }
    }
}