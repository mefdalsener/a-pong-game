using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BallMovement : MonoBehaviour
{

    [SerializeField] float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int randomDirection = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * speed * randomDirection, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
