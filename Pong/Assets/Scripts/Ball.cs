﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 Velocity = new Vector2(0.15f, 0.0f);
    public float YMax = 4f;
    public float YMin = 1.5f;
    public float XMin = 6f;
    public float XMax = 8f;
    public int LeftOrRight = 0;
    public int UpOrDown = 0;
    public bool SpacePressed = false;
    public bool ForcedStart = false;
    public GameObject PaddleHitSound;
    public GameObject WallHitSound;
    float previousVelocity = 1;
    // Start is called before the first frame update
    void Start()
    {
        Velocity.y = Random.Range(YMin, -YMax);
        Velocity.x = Random.Range(XMin, XMax);
        LeftOrRight = Random.Range(1, 3);
        if (LeftOrRight == 2 && Velocity.x < 0)
        {
            Velocity.x *= -1;
        }
        else if (LeftOrRight == 1 && Velocity.x > 0)
        {
            Velocity.x *= -1;
        }
        if (UpOrDown == 2 && Velocity.y < 0)
        {
            Velocity.y *= -1;
        }
        else if (UpOrDown == 1 && Velocity.y > 0)
        {
            Velocity.y *= -1;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if ((SpacePressed == false && Input.GetKey(KeyCode.Space)) || ForcedStart)
        {
            GetComponent<Rigidbody2D>().velocity = Velocity;
            SpacePressed = true;
            ForcedStart = false;
        }
        previousVelocity = GetComponent<Rigidbody2D>().velocity.y;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Floor floor = collision.gameObject.GetComponent<Floor>();
        PaddleMove1 P1 = collision.gameObject.GetComponent<PaddleMove1>();
        PaddleMove2 P2 = collision.gameObject.GetComponent<PaddleMove2>();
        if (floor != null)
        {
            Instantiate(WallHitSound);
            if (GetComponent<Rigidbody2D>().velocity.y == 0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, previousVelocity * -1);
            }
        }
        if (P1 != null || P2 != null)
        {
            Instantiate(PaddleHitSound);
        }

    }  
}
