using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public float speed = 3f;
    [SerializeField] float projectileLifespan = 3f;
    Rigidbody2D rigidBody;

    float triggerTime = 0f;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector3(0, speed, 0);
        triggerTime = Time.time + projectileLifespan;
    }

    private void Update()
    {
        if (Time.time > triggerTime)
        {
            Destroy(gameObject);
        }
    }
}
