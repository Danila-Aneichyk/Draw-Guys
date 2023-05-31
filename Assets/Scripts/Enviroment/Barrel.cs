using UnityEngine;

public class Barrel : MonoBehaviour
{
    [SerializeField] private GameObject _explosionEffect;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision detected");
            Explode(collision);
        }
    }

    private void Explode(Collision collision)
    {
        Instantiate(_explosionEffect, transform.position, Quaternion.identity);

        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}