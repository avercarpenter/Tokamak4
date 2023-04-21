using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    [SerializeField] private float magnetForce = 10.0f;
    [SerializeField] private bool isPulling = true;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Rigidbody2D otherRigidbody = other.gameObject.GetComponent<Rigidbody2D>();
            if (otherRigidbody)
            {
                Vector2 direction = (transform.position - other.transform.position).normalized;
                Vector2 force = direction * magnetForce;
                if (!isPulling)
                {
                    force *= -1f;
                }
                otherRigidbody.AddForce(force);
            }
        }
    }
}