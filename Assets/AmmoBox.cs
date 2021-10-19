using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : Item
{
    int amount = 10;

    protected override void ItemPickedUp()
    {
        GameManager.Instance.playerStats.AddAmmo(amount);
    }
}
