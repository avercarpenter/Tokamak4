using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainCam : MonoBehaviour
{

    public Transform player;
    public float verticalSpeed = 5f;
    public float diagonalSpeed = 5f;
    public Transform diagonalStartMarker;
    public Transform diagonalEndMarker;
    //public float verticleLimit = 10f;
    public Vector2 verticalOffset = new Vector2(0f, 2f);

    private bool followPlayer = true;

    private void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(player.position.x, player.position.y, transform.position.z);

        // Check if the player has reached the diagonal start marker
        if (followPlayer && targetPosition.y <= diagonalStartMarker.position.y)
        {
            followPlayer = false;
        }

        // If not following player, move diagonally towards end marker
        if (!followPlayer)
        {
            float step = diagonalSpeed * Time.deltaTime;
            Vector3 targetDiagonal = new Vector3(diagonalEndMarker.position.x, diagonalEndMarker.position.y, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, targetDiagonal, step);
        }
        // If following player, move vertically towards player
        else
        {
            Vector3 targetVertical = new Vector3(targetPosition.x + verticalOffset.x, targetPosition.y + verticalOffset.y, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, targetVertical, verticalSpeed * Time.deltaTime);
        }
    }
}
