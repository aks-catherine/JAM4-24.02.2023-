using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 10f;
    public Rigidbody rg;

    void Update()
    {
        var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed;
        vel.y = rg.velocity.y;
        rg.velocity = vel;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rg.AddForce(Vector3.up * jumpForce);
        }
    }   
}
   