using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RightScoreScript : MonoBehaviour
{

    public static BallScript Instance;
    int rightScore;
    int goalTarget;

    public static int finalRightScore;

    public Text RightScoreCount;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        //loads next scene
        if (rightScore == goalTarget && currentScene != 4)
        {
            rightScore = 0;
            SceneManager.LoadScene(currentScene + 1);
        }

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex; //gets active scene
        //for level 1 score increases by 1
        if (currentScene == 1)
        {
            rightScore += 1;
            finalRightScore += 1;

        }
        //for level 2 score increases by 2
        else if (currentScene == 2)
        {
            rightScore += 2;
            finalRightScore += 2;
        }
        //for level 3 score increases by 3
        else if (currentScene == 3)
        {
            rightScore += 3;
            finalRightScore += 3;
        }
        //calls ballScript
        RightScoreCount.text = rightScore.ToString();
        print(rightScore);
        BallScript ball;
        ball = GameObject.FindObjectOfType<BallScript>();
        ball.gameStart = false;
    }

    //a goal target is set for each level
    private void OnLevelWasLoaded(int level)
    {
        if (level == 1)
        {
            goalTarget = 10;
        }
        else if (level == 2)
        {
            goalTarget = 12;
        }
        else if (level == 3)
        {
            goalTarget = 18;
        } 

    }
}