using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // References the Rigidbody component
    public Rigidbody rb;

    // Forward and sideways forces
    public float forwardForce = 1000f, sidewayForce = 100f;

    // Start is called before the first frame update
    /*
    void Start()
    {
        //rb.useGravity = false;
        //rb.AddForce(0, 200, 500); 
        //Debug.Log("KEKW");
    }
    */

    // Update is called once per frame
    // Physics operations => better to use FixedUpdate instead of Update
    void FixedUpdate()
    {

        // The higher the framerate, the lower the deltaTime
        // The lower the framerate, the higher the deltaTime

        // Move the user forward (basically acceleration) (disabled atm)
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime););

        // Move forward
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        // Move backward
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }

        // Move right
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Move left
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Are we out of bounds?
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

        
    }

    private void Update()
    {
        // Test out mouse click and send to console (0 - left, 1 - right, 2 - middle)
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Pressed on the right mouse");
        }
    }
}
