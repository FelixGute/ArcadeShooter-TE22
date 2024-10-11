using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 3f;
    protected Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        OnStart();
    }

    protected virtual void OnStart()
    {
        rigidBody.velocity = new Vector2(rigidBody.velocity.x, -speed);
    }
}
