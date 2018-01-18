using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LeftScoreScript : MonoBehaviour {

    public static BallScript Instance; //calls ballScript
    int leftScore;
    int goalTarget;

    public static int finalLeftScore;
    
    public Text LeftScoreCount;
    

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if (leftScore == goalTarget && currentScene != 4)
        {
            leftScore = 0;
            SceneManager.LoadScene(currentScene + 1);
        }

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if (currentScene == 1)
        {
            leftScore += 1;
            finalLeftScore += 1;
        }
        else if (currentScene == 2)
        {
            leftScore += 2;
            finalLeftScore += 2;
        }
        else if (currentScene == 3)
        {
            leftScore += 3;
            finalLeftScore += 3;
        }

        LeftScoreCount.text = leftScore.ToString();
        print(leftScore);
        BallScript ball;
        ball = GameObject.FindObjectOfType<BallScript>();
        ball.gameStart = false;
    }

    void OnLevelWasLoaded(int level)
    {
        if(level == 1)
        {
            goalTarget = 10;
        }
        else if(level == 2)
        {
            goalTarget = 12;
        }
        else if (level == 3)
        {
            goalTarget = 18;
        }
    }

}
