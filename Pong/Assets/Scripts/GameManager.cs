using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Player1Score = 0;
    public int Player2Score = 0;
    public int NumberOfBalls = 1;
    public bool AddNewBall = false;
    public GameObject ball;
    public string LoadWinLevel1;
    public string LoadWinLevel2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AddNewBall)
        {
            GameObject newBall = Instantiate(ball, new Vector3(0, 0, 0), transform.rotation);
            newBall.GetComponent<Ball>().ForcedStart = true;
            AddNewBall = false;
        }
        if (Player1Score == 10)
        {
            SceneManager.LoadScene(LoadWinLevel1);
        }
        else if (Player2Score == 10)
        {
            SceneManager.LoadScene(LoadWinLevel2);
        }
    }
}
