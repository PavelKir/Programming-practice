using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    Transform playerTransform;
    float jumpOffset = 5f;
    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.y > 5)
        {
            jumpOffset = 5f;
        }
        else
        {
            jumpOffset = 0;
        }
        transform.position = new Vector3(playerTransform.position.x, jumpOffset, transform.position.z);
    }
}
