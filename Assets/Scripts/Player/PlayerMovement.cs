using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rigidBody;
    public float speed = 1000f;

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
    public void TempSpeedBoost(float speedIncrease)
    {
        speed += speedIncrease;
        print(speed);
    }
}
