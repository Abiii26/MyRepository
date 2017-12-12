using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 16) - 8;

        Vector3 newPaddlePos = new Vector3(2.92f, this.transform.position.y, 0.0f);

        newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -2.93f, 2.93f);

        this.transform.position = newPaddlePos;

    }
}
