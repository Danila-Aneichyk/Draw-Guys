using Dreamteck.Splines;
using UnityEngine;

public class PlayerVariantHandler : MonoBehaviour
{
    [SerializeField] private SplineComputer _splineComputer;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision with {collision.transform.name}");
        if (collision.gameObject.CompareTag(Tags.PlayerVariant))
        {
            PlayerVariant variant = collision.gameObject.GetComponent<PlayerVariant>();

            if (variant != null && !variant.IsCollided)
            {
                variant.IsCollided = true;
                variant.transform.SetParent(transform);
                SplineFollower variantFollower = variant.GetComponent<SplineFollower>();
                variantFollower.follow = true;
                variantFollower.spline = _splineComputer;
                variantFollower.SetDistance(15f);
            }
        }
    }
}