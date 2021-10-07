using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : Enemy
{
    public Transform projectileSpawner;
    public GameObject bulletPrefab;
    Transform playerTransform;
    float fireRate = 1.5f;
    float timeFromLastFire;
    // Start is called before the first frame update

    protected override void Start()
    {
        base.Start();
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        Shooting();
    }

    protected override void Moving()
    {
        if(playerTransform.position.x - transform.position.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    void Shooting()
    {
        timeFromLastFire += Time.deltaTime;
        if ((Vector2.Distance(playerTransform.position, transform.position) < 15f) && timeFromLastFire > fireRate)
        {
            timeFromLastFire = 0f;
            Instantiate(bulletPrefab, projectileSpawner.position, transform.rotation);
        }
    }
}
