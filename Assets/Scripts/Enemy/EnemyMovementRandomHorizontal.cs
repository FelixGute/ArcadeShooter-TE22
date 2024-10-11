using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementRandomHorizontal : EnemyMovement
{
    float horizontalSpeed;

    protected override void OnStart()
    {
        base.OnStart();
        horizontalSpeed = Random.Range(-1f, 1f);
        rigidBody.velocity = new Vector2(horizontalSpeed, rigidBody.velocity.y);
        print("start from enemyrandomhorizontal");
    }
}
