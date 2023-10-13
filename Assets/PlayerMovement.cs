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
            // TODO : 17 Ekim günü buradaki optimizasyon problemine bak.
            gameObject.GetComponent<Transform>().position += Vector3.forward* speed * Time.fixedDeltaTime;
                

        }
        //TODO  : A,S,D Tuşlarının hareketi eklenecek.

    }

}
