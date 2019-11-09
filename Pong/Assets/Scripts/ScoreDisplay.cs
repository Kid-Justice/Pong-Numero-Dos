using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreDisplay : MonoBehaviour
{
    public int Player = 1;
    public GameObject GMObject;
    GameManager GM;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        GM = GMObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (Player)
        {
        case 1:
            text.text = "" + GM.Player1Score;
            break;
        case 2:
            text.text = "" + GM.Player2Score;
            break;
        }
    } 
}
