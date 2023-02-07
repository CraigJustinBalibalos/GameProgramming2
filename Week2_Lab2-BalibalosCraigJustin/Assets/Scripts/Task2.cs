using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    public Rigidbody RigidBody_Movement;
    public float speed = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        RigidBody_Movement = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 player = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));

        RigidBody_Movement.AddForce(player * speed);

        // if(Input.GetKey(KeyCode.W)){
        //     RigidBody_Movement.AddForce(-transform.right * speed);
        // }
        // if(Input.GetKey(KeyCode.A)){
        //     RigidBody_Movement.AddForce(-transform.forward * speed);
        // }
        // if(Input.GetKey(KeyCode.S)){
        //     RigidBody_Movement.AddForce(transform.right * speed);
        // }
        // if(Input.GetKey(KeyCode.D)){
        //     RigidBody_Movement.AddForce(transform.forward * speed);
        // }
    }
}
