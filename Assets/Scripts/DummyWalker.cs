using UnityEngine;
using UnityEngine.AI;

namespace PlateauSamples.MiniatureViewer
{
    public class DummyWalker : MonoBehaviour
    {
        public float m_WalkRadius = 10.0f;
        NavMeshAgent m_NavMeshAgent;
        bool m_IsInitialized;

        void Start()
        {
            m_NavMeshAgent = GetComponent<NavMeshAgent>();
            if (m_NavMeshAgent != null && m_NavMeshAgent.isOnNavMesh)
            {
                SetRandomDestination();
                m_IsInitialized = true;
            }
        }

        void Update()
        {
            if (m_IsInitialized && !m_NavMeshAgent.pathPending)
            {
                if (m_NavMeshAgent.remainingDistance <= m_NavMeshAgent.stoppingDistance)
                {
                    if (!m_NavMeshAgent.hasPath || m_NavMeshAgent.velocity.sqrMagnitude == 0f)
                    {
                        SetRandomDestination();
                    }
                }
            }
        }

        void SetRandomDestination()
        {
            Vector3 randomDirection = Random.insideUnitSphere * m_WalkRadius;
            randomDirection += transform.position;
            if (NavMesh.SamplePosition(randomDirection, out NavMeshHit hit, m_WalkRadius, NavMesh.AllAreas))
            {
                m_NavMeshAgent.SetDestination(hit.position);
            }
        }
    }
}
