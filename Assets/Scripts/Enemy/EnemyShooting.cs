using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] float fireRate = 3f;
    [SerializeField] GameObject enemyBulletPrefab;

    float timeToShoot = 0f;
    void Start()
    {
        timeToShoot = Time.time + fireRate;
    }

    void Update()
    {
        if (Time.time > timeToShoot)
        {
            Instantiate(enemyBulletPrefab, transform.position, Quaternion.identity);
            timeToShoot = Time.time + fireRate;
        }
    }
}
