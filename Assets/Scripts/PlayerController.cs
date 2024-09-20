using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1000f;
    public int health = 100;
    public GameObject playerProjectilePrefab;
    [SerializeField] GameObject playerBombPrefab;
    public float fireDelay = 0.5f;

    Rigidbody2D rigidBody;
    float timeToShoot = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rigidBody.velocity = new Vector3(horizontal, vertical, 0) * speed * Time.fixedDeltaTime;

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.Space)) {
            if(Time.time > timeToShoot)
            {
                Instantiate(playerProjectilePrefab, transform.position, Quaternion.identity);
                
                timeToShoot = Time.time + fireDelay;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && Time.time > timeToShoot)
        {
            Instantiate(playerBombPrefab, transform.position, Quaternion.identity);
            timeToShoot = Time.time + fireDelay;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Something hit me!");
        health -= 10;
        if(health <= 0)
        {
            Debug.Log("Dead");
        }
    }

    public void TempSpeedBoost(float speedIncrease)
    {
        speed += speedIncrease;
        print(speed);
    }
}
