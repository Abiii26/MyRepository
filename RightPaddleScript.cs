using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //paddle moves along with mouse movement from one given position to the other
        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 16) - 8;

        Vector3 newPaddlePos = new Vector3(transform.position.x, this.transform.position.y, transform.position.z);

        newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -2.90f, 2.45f);

        this.transform.position = newPaddlePos;

    }
}
