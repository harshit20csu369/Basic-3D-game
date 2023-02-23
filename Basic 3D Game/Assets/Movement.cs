using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float key;
     Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
      rb=  GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 6, ForceMode.VelocityChange);
        }
       key = Input.GetAxis("Horizontal");
        
       rb.velocity = new Vector3(key*speed, rb.velocity.y, 0);
    }
}
