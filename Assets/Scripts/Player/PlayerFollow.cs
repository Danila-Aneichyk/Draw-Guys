using UnityEngine;
using UnityEngine.AI;

public class PlayerFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private NavMeshAgent _navMesh;
    private bool _shouldFollow = false;

    private void Start()
    {
        _navMesh = GetComponent<NavMeshAgent>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Tags.Player))
        {
            _shouldFollow = true;
        }
    }

    private void Update()
    {
        if (_shouldFollow)
        {
            Follow();
        }
    }

    private void Follow()
    {
        _navMesh.SetDestination(_target.transform.position);
    }
}