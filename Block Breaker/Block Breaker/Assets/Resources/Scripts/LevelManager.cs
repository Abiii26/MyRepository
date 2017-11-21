using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadNewScene(string sceneName)
    {
        Brick.breakableCount = 0;
        SceneManager.LoadScene(sceneName);
    }

    public void LoadNextScene()
    {
        Brick.breakableCount = 0;
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene+1);
    }

    public void BrickDestroy()
    {
        if(Brick.breakableCount <= 0)
        {
            LoadNextScene();
        }
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
