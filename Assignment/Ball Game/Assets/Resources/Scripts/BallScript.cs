using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    bool gameStart = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0) && !gameStart)
        {
            gameStart = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }

    }
}
