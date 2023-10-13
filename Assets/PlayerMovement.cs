using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.05f;
    


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
           
            gameObject.GetComponent<Transform>().position += Vector3.forward* speed * Time.fixedDeltaTime;


        }
    }

}
