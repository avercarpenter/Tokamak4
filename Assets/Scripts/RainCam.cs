using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainCam : MonoBehaviour
{

    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = playerTransform.position.y;
        transform.position = pos;
    }
}
