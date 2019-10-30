using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private float thrustForward = 70.0F;
    private float thrustBackward = 20.0F;
    private float rotationSpeed = 15.0F;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb2D.AddForce(transform.up * thrustForward);
        }
        if (Input.GetKey("s"))
        {
            rb2D.AddForce(transform.up * -thrustBackward);
        }
        if (Input.GetKey("a"))
        {
            rb2D.AddTorque(rotationSpeed, ForceMode2D.Force);
        }
        if (Input.GetKey("d"))
        {
            rb2D.AddTorque(-rotationSpeed, ForceMode2D.Force);
        }

    }
}
