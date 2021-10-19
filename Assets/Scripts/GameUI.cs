using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI playerHPText;
    [SerializeField]
    TextMeshProUGUI playerAmmo;

    private void Update()
    {
        playerHPText.text = "HP: " + GameManager.Instance.playerStats.PlayerHP;
        playerAmmo.text = "Ammo: " + GameManager.Instance.playerStats.Ammo;
    }
}
