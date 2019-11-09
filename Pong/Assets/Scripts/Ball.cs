using System.Collections;
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
        if (SpacePressed == false && Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = Velocity;
            SpacePressed = true;
        }
        if (ForcedStart)
        {
            GetComponent<Rigidbody2D>().velocity = Velocity;
            ForcedStart = false;
        }

    }
    /* private void OnCollisionEnter2D(Collision2D collision)
    {
        PaddleMove1 Paddle1 = collision.gameObject.GetComponent<PaddleMove1>();
        PaddleMove2 Paddle2 = collision.gameObject.GetComponent<PaddleMove2>();
        
    }
    */
}
