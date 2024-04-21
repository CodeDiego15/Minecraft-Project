using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
      public float runSpeed = 7;
   public float rotationSpeed = 250;
    public float jumpForce = 10f;
    public Rigidbody rb;

   private float x, y;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x*Time.deltaTime *rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime*runSpeed);
         
         if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
