using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToTheMainMenu : MonoBehaviour
{
    public void LoadMainMenu()
    {
        PlayerPrefs.SetInt("score", 0);
        SceneManager.LoadScene("Assets/Scenes/StartMenu.unity");
    }
}
