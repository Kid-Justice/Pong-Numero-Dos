using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public float Edge = 8.5f;
    GameObject GMObject;
    GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GMObject = GameObject.FindGameObjectWithTag("GameManager");
        GM = GMObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= Edge)
        {
            GM.Player1Score++;
            Destroy(gameObject);
            GM.AddNewBall = true;
        }
        else if (transform.position.x <= -Edge)
        {
            GM.Player2Score++;
            Destroy(gameObject);
            GM.AddNewBall = true;
        }
    }
}
