using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int Player = 1;
    public GameObject GMObject;
    GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GMObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball BallScript = collision.gameObject.GetComponent<Ball>();
        if (BallScript != null)
        {
            switch (Player)
            {
                case 1:

                    break;
                case 2:

                    break;
            }
        }
        Destroy(collision.gameObject);
    }
}
