using Unity.VisualScripting;
using UnityEngine;
//using UnityEngine.InputSystem;

public class FlapWings : MonoBehaviour
{
    
    [SerializeField] private float _velocity = 2.2f;
    [SerializeField] private float _rotationSpeed = 2f;
    public KeyCode upArrow;

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
     
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetMouseButtonDown(0))
        {
            _rb.linearVelocity = Vector2.up * _velocity;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.linearVelocity.y * _rotationSpeed);
    }
}

