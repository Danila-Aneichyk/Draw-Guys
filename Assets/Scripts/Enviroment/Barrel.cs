using UnityEngine;

public class Barrel : MonoBehaviour
{
    [SerializeField] private GameObject _explosionEffect;
    [SerializeField] private Transform _positionToExplode;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.CompareTag(Tags.Player))
        {
            Debug.Log("Collision detected");
            Explode(collision);
        }
    }

    private void Explode(Collision collision)
    {
        Instantiate(_explosionEffect, _positionToExplode.position, Quaternion.identity);

        Destroy(collision.gameObject, 2);
        Destroy(gameObject);
    }
}