using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard_Controller : MonoBehaviour
{

    public static ScoreBoard_Controller instance;

    public Text player1_ScoreText;
    public Text player2_ScoreText;

    public int player1_Score;
    public int player2_Score;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        player1_Score = player2_Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Giveplayer_1Piont()
    {
        player1_Score += 1;
        player1_ScoreText.text = player1_Score.ToString();

    }

    public void Giveplayer_2Piont()
    {
        player2_Score += 1;
        player2_ScoreText.text = player2_Score.ToString();
    }
}
