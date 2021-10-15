using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GameManager : MonoBehaviour
{
    class PlayerStats
    {
        int playerHP = 100;
        int shotDamage = 20;
        int jumpDamage = 10;

        public int PlayerHP
        {
            get
            {
                return playerHP;
            }
        }
        public int ShotDamage
        {
            get
            {
                return shotDamage;
            }
        }
        public int JumpDamage
        {
            get
            {
                return jumpDamage;
            }
        }
        public void AddHP(int amount)
        {
            playerHP += amount;
        }
        public void DamageReceived(int damage)
        {
            playerHP -= damage;
            if (playerHP<=0)
            {
                // конец игры
            }
        }
        
    }
    public static GameManager Instance;
    PlayerStats playerStats;
    // Start is called before the first frame update
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
        playerStats = new PlayerStats();
    }


}
