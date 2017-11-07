using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncDecScript : MonoBehaviour {

    int myNumber = 50;

	// Use this for initialization
	void Start () {
        print("Increment or Decrement!");
        print("To play press the Up or Down Arrow Keys");

        print("The number is " + myNumber);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("up"))
        {
            print("Up Arrow pressed!");
            myNumber++;
        }

        else if (Input.GetKeyDown("down"))
        {
            print("Down Arrow pressed!");
            myNumber--;
        }

        else if (Input.GetKeyDown("return"))
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
