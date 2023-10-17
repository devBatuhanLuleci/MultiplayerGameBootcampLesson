using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.05f;

    private Transform myTransform;
    private Rigidbody myRigidbody;

    private float horizontal;
    private float vertical;

    private void Awake()
    {
        myTransform = GetComponent<Transform>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        vertical = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        Move(myRigidbody);

    }
    void Move(Rigidbody Rigidbody)
    {

        Vector3 newPos = new Vector3(horizontal * speed * Time.fixedDeltaTime,
                                       Rigidbody.velocity.y,
                                      vertical * speed * Time.fixedDeltaTime);

        Rigidbody.velocity = newPos;



    }
}
