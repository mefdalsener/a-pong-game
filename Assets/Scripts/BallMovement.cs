using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BallMovement : MonoBehaviour
{

    [SerializeField] float speed = 5.0f;
    Rigidbody rb;

    Vector3 direction;
    void Start()
    {

        int randomDirection = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;

        rb = GetComponent<Rigidbody>();
        Shoot(Vector3.right * randomDirection);
    }
    public void Shoot(Vector3 direction)
    {
        rb.linearVelocity = direction.normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Racket"))
        {
            Vector3 racket = collision.collider.bounds.center;
            Vector3 ballPosition = transform.position;

            Vector3 direction = (ballPosition - racket).normalized;

            Shoot(direction);
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            Vector3 normal = collision.contacts[0].normal;
            Vector3 reflected = Vector3.Reflect(rb.linearVelocity.normalized, normal);
            Shoot(reflected);
        }
    }
}
