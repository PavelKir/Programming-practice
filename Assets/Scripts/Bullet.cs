using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D bulletRb;
    Vector2 startPos;
    protected float bulletSpeed = 20f;
    float bulletMaxFlyDistance = 20;
    protected virtual void Start()
    {
        startPos = transform.position;
        bulletRb = GetComponent<Rigidbody2D>();
        bulletRb.velocity = transform.right * bulletSpeed;
    }

    void Update()
    {
        if (Mathf.Abs(startPos.x - transform.position.x) > bulletMaxFlyDistance)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<Enemy>().DamageReceived(GameManager.Instance.playerStats.ShotDamage);
        }
    }
}
