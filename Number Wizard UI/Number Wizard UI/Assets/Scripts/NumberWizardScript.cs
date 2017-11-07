using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizardScript : MonoBehaviour {

    public Text CompGuess;

    int min = 0;
    int max = 0;
    int guess = 0;
    
    // Use this for initialization
    void Start () {

        StartGame();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("up"))
        //if(Input.GetKeyDown(KeyCode.UpArrow))
        {
           
            min = guess + 1;
            NextGuess();
        }

        else if (Input.GetKeyDown("down"))
        {
       
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown("return"))
        {
            
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
        CompGuess.text = guess + "?";
       
    }

    void StartGame()
    {
        min = 1;
        max = 1000;

        
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    public void Correct()
    {
        SceneManager.LoadScene("Lose");

    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Start");
    }
}
