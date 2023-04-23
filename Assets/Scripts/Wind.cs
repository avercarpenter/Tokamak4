using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{

    public float windStrength = 10f;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody2D otherRb = other.GetComponent<Rigidbody2D>();
            if (otherRb != null)
            {
                Vector2 windDirection = transform.right; // Change this to adjust the direction of the wind
                otherRb.AddForce(windDirection * windStrength);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody2D otherRb = other.GetComponent<Rigidbody2D>();
            if (otherRb != null)
            {
                otherRb.velocity = Vector2.zero; // Reset the player's velocity when they leave the fan's trigger zone
            }
        }
    }

    public bool IsInTriggerZone(Vector2 position)
    {
        Collider2D triggerCollider = GetComponent<Collider2D>();
        if (triggerCollider != null)
        {
            return triggerCollider.OverlapPoint(position);
        }
        return false;
    }
}
