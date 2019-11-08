using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 Velocity = new Vector2(0.15f, 0.0f);
    public float YRange = 0.25f;
    public float XMin = 0.05f;
    public float XMax = 0.25f;
    public int LeftOrRight = 0;
    // Start is called before the first frame update
    void Start()
    {
        Velocity.y = Random.Range(YRange, -YRange);
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
        GetComponent<Rigidbody2D>().velocity = Velocity;
    }

    // Update is called once per frame
    void Update()
    {

 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PaddleMove1 Paddle1 = collision.gameObject.GetComponent<PaddleMove1>();
        PaddleMove2 Paddle2 = collision.gameObject.GetComponent<PaddleMove2>();
        
    }
}
