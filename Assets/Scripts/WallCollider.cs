using UnityEngine;

public class WallCollider : MonoBehaviour
{
    float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody ballRb = other.GetComponent<Rigidbody>();

        if (ballRb == null) return;

        Vector3 normal = (other.transform.position - transform.position).normalized;
        Vector3 yansima = Vector3.Reflect(ballRb.linearVelocity.normalized, normal);
        ballRb.linearVelocity = yansima * speed;
    }
}
