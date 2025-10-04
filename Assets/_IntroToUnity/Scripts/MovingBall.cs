using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovingBall : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Game has started.");
    }

    void FixedUpdate() // physics update
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // movement direction
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // smoother movement: use velocity
        rb.AddForce(movement * speed, ForceMode.Acceleration);
    }
}
