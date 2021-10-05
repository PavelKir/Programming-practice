using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D bulletRb;
    Vector2 startPos;
    float bulletSpeed = 20f;
    float bulletMaxFlyDistance = 20;
    void Start()
    {
        startPos = transform.position;
        bulletRb = GetComponent<Rigidbody2D>();
        bulletRb.velocity = transform.right * bulletSpeed;
    }

    private void Update()
    {
        if (Mathf.Abs(startPos.x - transform.position.x) > bulletMaxFlyDistance)
        {
            Destroy(gameObject);
        }
    }
}
