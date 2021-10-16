using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet
{
    public int damage;
    protected override void Start()
    {
        bulletSpeed = 10f;
        base.Start();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.playerStats.DamageReceived(damage);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
