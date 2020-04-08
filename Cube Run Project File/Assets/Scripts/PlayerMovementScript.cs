/*using System.Collections;
using System.Collections.Generic;*/
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForceZ = 10f;
    public float sideForceX = 5f;

    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForceZ * Time.deltaTime);  

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForceX * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForceX * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}
