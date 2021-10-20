using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    float horizontalInput;
    Rigidbody2D playerRb;
    float speed = 10;
    float jumpPower = 10;
    bool isPlayerGrounded = true;

    public GameObject bulletPrefab;
    public Transform projectileSpawner;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // ABSTRACTION
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        RotatePlayer();
        Shooting();
        DeathByFalling();

        if (Input.GetKeyDown(KeyCode.Space)&& isPlayerGrounded)
        {            
            playerRb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            isPlayerGrounded = false;
        }
    }

    void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && GameManager.Instance.playerStats.Ammo != 0)
        {
            Instantiate(bulletPrefab, projectileSpawner.position, gameObject.transform.rotation);
            GameManager.Instance.playerStats.Ammo = -1;
        }
    }
    private void FixedUpdate()
    {
        playerRb.velocity = new Vector2(speed * horizontalInput, playerRb.velocity.y);
    }

    void RotatePlayer()
    {
        if (horizontalInput < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (horizontalInput > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    void DeathByFalling()
    {
        if (transform.position.y < -8)
        {
            GameManager.Instance.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("Enemy"))
        {
            isPlayerGrounded = true;
        }
        if (collision.gameObject.CompareTag("Exit"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
