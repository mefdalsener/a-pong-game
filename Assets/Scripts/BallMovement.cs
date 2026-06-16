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
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.left * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
