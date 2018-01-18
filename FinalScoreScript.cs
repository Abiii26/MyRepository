using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreScript : MonoBehaviour {

    public Text finalLeftScore;
    int FinalLeftScore;

    public Text finalRightScore;
    int FinalRightScore;

    public Text WinScore;

    // Use this for initialization
    void Start () {
        //displays the total score of player 1
        FinalLeftScore = LeftScoreScript.finalLeftScore;
        finalLeftScore.text = "Player 1 Scores " +FinalLeftScore+" / 40";
        //displays the total score of player 2
        FinalRightScore = RightScoreScript.finalRightScore;
        finalRightScore.text = "Player 2 Scores " +FinalRightScore+" / 40";

        //if player 1 score more than player 2, than player 1 is the winner
        if (FinalLeftScore > FinalRightScore)
        {
            WinScore.text = "Player 1 Wins the Ball Game";
        }
        //if player 1 score less than player 2, than player 2 is the winner
        else if (FinalLeftScore < FinalRightScore)
        {
            WinScore.text = "Player 2 Wins the Ball Game";
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
