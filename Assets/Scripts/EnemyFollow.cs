using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] private Transform playerTransform;

    private void Awake()
    {
        agent=GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if(playerTransform!=null)
        {
            agent.SetDestination(playerTransform.position);
        }
    }
}
