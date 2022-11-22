using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleScenesOnFailure : MonoBehaviour
{
    public void RestartCurrentLevel()
    {
        if(PlayerPrefs.GetInt("FailedLevelIndex") == SceneManager.GetSceneByName("Scenes/Level1").buildIndex ) // if user failed on level1, set score to 0 and start again.
        {
            PlayerPrefs.SetInt("score", 0);
        }
        SceneManager.LoadScene(PlayerPrefs.GetInt("FailedLevelIndex"));
    }

    public void LoadMainMenu()
    {
        PlayerPrefs.SetInt("score", 0);
        SceneManager.LoadScene("Scenes/StartMenu");
    }

}
