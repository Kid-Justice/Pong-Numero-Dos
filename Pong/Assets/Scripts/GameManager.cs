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
    public int ScoreToWin = 10;
    public string LoadWinLevel1;
    public string LoadWinLevel2;
    public bool FastPong = false;
    public int BallCount = 1;
    int player1PreviousScore = 0;
    int player2PreviousScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FastPong)
        {
            if (player1PreviousScore < Player1Score)
            {
                BallCount++;
                player1PreviousScore = Player1Score;
                for (int i = 0; i < BallCount; i++)
                {
                    GameObject newBall = Instantiate(ball, new Vector3(0, 0, 0), transform.rotation);
                    newBall.GetComponent<Ball>().ForcedStart = true;
                }
            }
            if (player2PreviousScore < Player2Score)
            {
                BallCount++;
                player2PreviousScore = Player2Score;
                for (int i = 0; i < BallCount; i++)
                {
                    GameObject newBall = Instantiate(ball, new Vector3(0, 0, 0), transform.rotation);
                    newBall.GetComponent<Ball>().ForcedStart = true;
                }
            }
            if (Player1Score >= ScoreToWin)
            {
                SceneManager.LoadScene(LoadWinLevel1);
            }
            else if (Player2Score >= ScoreToWin)
            {
                SceneManager.LoadScene(LoadWinLevel2);
            }
        }
  
        else
        {
            if (AddNewBall)
            {
                GameObject newBall = Instantiate(ball, new Vector3(0, 0, 0), transform.rotation);
                newBall.GetComponent<Ball>().ForcedStart = true;
                AddNewBall = false;
            }
            if (Player1Score >= ScoreToWin)
            {
                SceneManager.LoadScene(LoadWinLevel1);
            }
            else if (Player2Score >= ScoreToWin)
            {
                SceneManager.LoadScene(LoadWinLevel2);
            }
        }
    }
}
