using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raindroip2 : MonoBehaviour
{
    public float speed = 5f;
    public float gravity = 9.81f;

    private void FixedUpdate()
    {
        // Move player horizontally
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(new Vector2(horizontalInput * speed * Time.deltaTime, 0f));

        // Apply downward force
        transform.position += new Vector3(0f, -gravity * Time.deltaTime, 0f);
    }
}
