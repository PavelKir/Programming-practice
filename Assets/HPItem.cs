using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPItem : Item
{
    int amount = 20;

    protected override void ItemPickedUp()
    {
        GameManager.Instance.playerStats.AddHP(amount);
    }
}
