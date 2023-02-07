using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task4 : MonoBehaviour
{
    public Rigidbody trap;
    // Start is called before the first frame update
    void Start()
    {
        trap = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col){
        trap = col.gameObject.GetComponent<Rigidbody>();
        trap.AddForce(-col.contacts[0].normal*250);
    }
}
