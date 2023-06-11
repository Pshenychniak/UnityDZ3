using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _rotationSpeed;

    private void Start()
    {
        Rotate360();
    }

    private void Rotate360()
    {
        _rigidbody.AddTorque(Vector3.up * _rotationSpeed, ForceMode.Acceleration);
    }
}
