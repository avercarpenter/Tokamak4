using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raindrop : MonoBehaviour
{

    public float speed; 

    private Rigidbody2D rb; 
    private Vector2 moveVelocity; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed; 
           
            // Apply wind force if player is in fan's trigger collider
        Wind fanController = FindObjectOfType<Wind>(); // Get reference to the FanController script
        if (fanController != null && fanController.IsInTriggerZone(transform.position))
        {
            Vector2 windDirection = fanController.transform.position - transform.position;
            rb.AddForce(windDirection.normalized * fanController.windStrength);
        }
    }
    

    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
