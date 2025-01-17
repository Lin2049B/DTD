using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
     public Rigidbody rb;

    public float fowardForce = 1000f;
    public float sideForce = 500f;
    // Start is called before the first frame update

 void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("No Rigidbody found on this GameObject!");
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,fowardForce*Time.deltaTime);
        if (UnityEngine.Input.GetKey("w"))
        {
            rb.AddForce(fowardForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
            Debug.Log("fwd");
        }

        if (UnityEngine.Input.GetKey("s"))
        {
            rb.AddForce(-fowardForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (UnityEngine.Input.GetKey("d"))
        {
            rb.AddForce(sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
         
         if (UnityEngine.Input.GetKey("a"))
        {
            rb.AddForce(-sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            //FindObjectOfType<GameManager>().EndGame();
        }
    }
}
