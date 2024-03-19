using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 angularV, v;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.angularVelocity = angularV;
            rb.velocity = v;
        }
        rb.AddForce(Vector3.Cross(rb.angularVelocity, rb.velocity));
    }
}
