using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleScript : MonoBehaviour {

    float speed = 4.5f; //speed at which the paddle moves


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        //when up arrow key pressed paddle smoothly moves upwards until it hits the top border
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            Vector3 paddlepos = transform.position;
            paddlepos.y += speed * Time.deltaTime;
            paddlepos.y = Mathf.Clamp(paddlepos.y, -2.90f, 2.45f);
            transform.position = paddlepos;
        }

        //when down arrow key pressed paddle smoothly moves downwards until it hits the bottom border
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 paddlepos = transform.position;
            paddlepos.y -= speed * Time.deltaTime;
            paddlepos.y = Mathf.Clamp(paddlepos.y, -2.90f, 2.45f);
            transform.position = paddlepos;
        }


    }
}
