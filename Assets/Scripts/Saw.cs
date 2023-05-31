using UnityEngine;

public class Saw : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 50f;

    private Vector3 _defaultRotation;

    private void Start()
    {
        _defaultRotation = transform.rotation.eulerAngles;
    }

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        float currentRotation = transform.rotation.eulerAngles.z;

        float newRotation = currentRotation + _rotationSpeed + Time.deltaTime;

        transform.rotation = Quaternion.Euler(_defaultRotation.x, _defaultRotation.y, newRotation);
    }
}