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

    //loads a new scene
    public void LoadNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }

    //when quit clicked program stops
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
