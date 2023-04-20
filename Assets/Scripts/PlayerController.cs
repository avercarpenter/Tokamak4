using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed; 

    private Rigidbody2D  rb; 
    private Vector2 moveVelocity; 

    //camera bounds
    private Camera mainCamera;
    private Vector2 screenBounds;
    private float playerWidth;
    private float playerHeight;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        mainCamera = Camera.main;
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
        playerWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        playerHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;

    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
       // moveVelocity = moveInput.normalized * speed; 

    }

    void FixedUpdate()
    {
        float hozMovement = Input.GetAxis("Horizontal");
        float verMovement = Input.GetAxis("Vertical");

        rb.AddForce(new Vector2(hozMovement * speed, verMovement * speed));
    }

    void LateUpdate ()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + playerWidth, screenBounds.x - playerWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + playerHeight, screenBounds.y - playerHeight);
        transform.position = viewPos;
    }
}
