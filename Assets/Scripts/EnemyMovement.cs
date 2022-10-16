using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5;
    public float scale = 1;
    private Rigidbody2D body;
    private bool movingLeft = true;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 vel = new Vector2(speed, 0);

        body.velocity = vel;
        if (!movingLeft)
            transform.localScale = new Vector3(scale, scale, 1);
        else
            transform.localScale = new Vector3(-scale, scale, 1);
        checkForPlatformEnd();
    }

    void checkForPlatformEnd()
    {
        RaycastHit2D hitGround, hitWall;

        if (!movingLeft) {
            Vector2 rayLeft = new Vector2(-0.5f, -0.5f);
            Vector2 rayLeftWall = new Vector2(-0.5f, 0f);

            hitGround = Physics2D.Raycast(transform.position, rayLeft, 1.0f, LayerMask.GetMask("Ground"));
            hitWall = Physics2D.Raycast(transform.position, rayLeftWall, 1.0f, LayerMask.GetMask("Ground"));
        }
        else {
            Vector2 rayRight = new Vector2(0.5f, -0.5f);
            Vector2 rayRightWall = new Vector2(0.5f, 0f);

            hitGround = Physics2D.Raycast(transform.position, rayRight, 1.0f, LayerMask.GetMask("Ground"));
            hitWall = Physics2D.Raycast(transform.position, rayRightWall, 1.0f, LayerMask.GetMask("Ground"));
        }

        if (hitGround.collider == null || hitWall.collider != null) {
            speed = -speed;
            movingLeft = !movingLeft;
        }
    }
}
