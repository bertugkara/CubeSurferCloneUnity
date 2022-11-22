using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailHandler : MonoBehaviour
{

    public static FailHandler Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void HandleFail() // user failed no more box left.
    {
        PlayerPrefs.SetInt("score", ScoreManager.Instance.GetScore());
        PlayerPrefs.SetInt("FailedLevelIndex", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Assets/Scenes/FailedScreen.unity");
    }
}
