using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerTest : MonoBehaviour
{
    public Rigidbody2D rb;
    public float JumpForce;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }   
    }
}
