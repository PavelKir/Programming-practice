using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperEnemy : Enemy
{
    [SerializeField]
    float jumpForce = 7f;
    protected override void Moving()
    {
        enemyRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
