using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats
{
    int playerHP = 50;
    int shotDamage = 10;
    int jumpDamage = 10;
    int ammo = 0;

    public int PlayerHP
    {
        get
        {
            return playerHP;
        }
        set
        {
            playerHP -= value;
            if (playerHP <= 0)
            {
                playerHP = 0;
                GameManager.Instance.GameOver();
            }
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
    public int Ammo
    {
        get
        {
            return ammo;
        }
        set
        {
            ammo += value;
        }
    }
    public void AddHP(int amount)
    {
        playerHP += amount;
        if(playerHP > 50)
        {
            playerHP = 50;
        }
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
    }

    public void GameOver()
    {
        isGameOver = true;
        SceneManager.LoadScene(0);
    }
    public void StartNewGame()
    {
        playerStats = new PlayerStats();
    }
}
