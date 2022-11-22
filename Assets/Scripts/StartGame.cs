using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void PlayGame()
    {
        PlayerPrefs.SetInt("score", 0);
        SceneManager.LoadScene("Scenes/Level1");

    }
}
