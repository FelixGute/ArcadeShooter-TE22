using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f;
    [SerializeField] bool randomHorizontalMovement = true;
    Rigidbody2D rigidBody;

    float horizontalSpeed = 0f;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        if (randomHorizontalMovement)
        {
            horizontalSpeed = Random.Range(-1f, 1f);
        }

        rigidBody.velocity = new Vector3(horizontalSpeed, -speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
