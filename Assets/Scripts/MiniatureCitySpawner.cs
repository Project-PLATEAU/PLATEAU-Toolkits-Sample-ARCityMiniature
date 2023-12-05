using UnityEngine;

namespace PlateauSamples.MiniatureViewer
{
    public class MiniatureCitySpawner : MonoBehaviour
    {
        public GameObject[] m_SpawnPrefabs;
        public GameObject m_DummyPrefab;
        public Transform m_MiniatureCity;
        public int m_NumCharacters = 100;
        public float m_SpawnRadius = 30.0f;
        bool m_HasSpawned = false;

        void Start()
        {
            SetToRootTransform();
        }

        void Update()
        {
            if (m_MiniatureCity != null && !m_HasSpawned)
            {
                for (int i = 0; i < m_NumCharacters; i++)
                {
                    SpawnCharacterWithDummy();
                }
                m_HasSpawned = true;
            }
            else if (m_MiniatureCity == null)
            {
                m_HasSpawned = false;
            }
        }

        void SetToRootTransform()
        {
            transform.SetParent(null);
            transform.position = Vector3.zero;
            transform.rotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        void SpawnCharacterWithDummy()
        {
            Vector3 spawnPosition = RandomPositionOnNavMesh(transform.position, m_SpawnRadius, -1);
            if (spawnPosition == Vector3.zero)
            {
                return;
            }

            GameObject characterPrefab = m_SpawnPrefabs[Random.Range(0, m_SpawnPrefabs.Length)];
            GameObject dummy = Instantiate(m_DummyPrefab, spawnPosition, Quaternion.identity, transform); // 親を指定
            GameObject character = Instantiate(characterPrefab, spawnPosition, Quaternion.identity, transform); // 親を指定

            TransformMapper transfer = character.AddComponent<TransformMapper>();
            transfer.m_DummyObject = dummy.transform;
            transfer.m_MiniatureCity = m_MiniatureCity;
        }

        Vector3 RandomPositionOnNavMesh(Vector3 origin, float distance, int areaMask)
        {
            Vector3 randomDirection = Random.insideUnitSphere * distance;
            randomDirection += origin;
            UnityEngine.AI.NavMeshHit hit;
            if (UnityEngine.AI.NavMesh.SamplePosition(randomDirection, out hit, distance, areaMask))
            {
                return hit.position;
            }
            return Vector3.zero;
        }
    }
}
