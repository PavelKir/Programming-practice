using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats
{
    int playerHP = 50;
    int shotDamage = 10;
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
        if (playerHP <= 0)
        {
            GameManager.Instance.GameOver();
        }
        Debug.Log(PlayerHP);
    }

}


public class GameManager : MonoBehaviour
{
    

    public bool isGameOver = false;
    public static GameManager Instance;
    public PlayerStats playerStats;
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

    public void GameOver()
    {
        isGameOver = true;
        SceneManager.LoadScene(0);
    }
}
