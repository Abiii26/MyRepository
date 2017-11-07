using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardScript : MonoBehaviour {

    int min = 0;
    int max = 0;
    int guess = 0;
    
    // Use this for initialization
    void Start () {
        print("Welcome to Number Wizard!");
        print("Pick a number between 1 and 1000!");

        print("Is the number higher, lower or equal to " + guess + "?");
        print("Higher: UP arrow, Lower: DOWN arrow, Equal: ENTER");
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("up"))
        //if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up Arrow pressed!");
            min = guess + 1;
            NextGuess();
        }

        else if (Input.GetKeyDown("down"))
        {
            print("Down Arrow pressed!");
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown("return"))
        {
            print("Enter Key pressed!");
            print("You Guessed!");
            StartGame();
        }
    }

    void NextGuess()
    {
        /*
         * This method always generates a new guess and prints it in the console window
         */

        //guess = (min + max) / 2; //Guess is the middle value of the current range

        System.Random rand = new System.Random(); // creates the copy of the Random class so that you can use its methods
        guess = rand.Next(min, (max+1)); // Next is a method which generates a random value between the specified range 

        print("Is the number higher, lower or equal to " + guess + "?");
        print("Higher: UP arrow, Lower: DOWN arrow, Equal: ENTER");
    }

    void StartGame()
    {
        min = 1;
        max = 1000;

        print("Welcome to Number Wizard!");
        print("Pick a number between 1 and 1000!");

        NextGuess();
    }
}
