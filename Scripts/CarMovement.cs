using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }
    public void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  // ileriye hareketi sa?l?yor

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
