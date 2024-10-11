using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementFollowPlayer : EnemyMovement
{

    GameObject player;

    protected override void OnStart()
    {
        base.OnStart();

        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (player.transform.position.x < transform.position.x)
        {
            rigidBody.velocity = new Vector2(-1f, rigidBody.velocity.y);
        }
        else
        {
            rigidBody.velocity = new Vector2(1f, rigidBody.velocity.y);
        }
    }
}
