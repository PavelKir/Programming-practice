using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Rigidbody2D enemyRb;
    protected int enemyShotDamage = 20;
    protected int enemyDamage = 10;
    protected int enemyHP = 10;

    private void Awake()
    {
        enemyRb = GetComponent<Rigidbody2D>();
    }

    protected virtual void Start()
    {
        InvokeRepeating("Moving", 0, 1.5f);
    }

    protected virtual void Moving()
    {

    }
    public void DamageReceived(int damage)
    {
        enemyHP -= damage;
        if (enemyHP <=0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if((collision.gameObject.transform.position.y - transform.position.y) > collision.gameObject.GetComponent<CapsuleCollider2D>().size.y)
            {
                DamageReceived(GameManager.Instance.playerStats.JumpDamage);
            }
            else
            {
                GameManager.Instance.playerStats.DamageReceived(enemyDamage);
            }
        }
    }
}
