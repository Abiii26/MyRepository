using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallScript : MonoBehaviour {

    Vector3 ballPosition;
    public bool gameStart = false;


    // Use this for initialization
    void Start () {
        //position on the ball on start
        ballPosition = new Vector3(0.0f, 0.014f, -6.51f);
	}
	
	// Update is called once per frame
	void Update () {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        //if game has not started ball waits for user action
        if (!gameStart)
        {
            this.transform.position = ballPosition;
        }
        //if mouse clicked game has started and ball moves
        if (Input.GetMouseButtonDown(0) && !gameStart)
        {
            gameStart = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(3f, 10f);
        }
        //when in level 2 and 3 ball velocity increases
        if ((currentScene == 2) && (currentScene == 3))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(6f, 10f);
        }

    }


}
