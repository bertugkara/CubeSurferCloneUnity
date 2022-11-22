using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static ScoreManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this) // Singleton pattern to reach the score manager.
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
            scoreText.text = PlayerPrefs.GetInt("score").ToString();
        }

        else if (PlayerPrefs.HasKey("score"))
        {
           scoreText.text = PlayerPrefs.GetInt("score").ToString();
        }
    }

    private void Update()
    {
        int tempScore = PlayerPrefs.GetInt("score") + GetLocalScoreOfThisLevel();
        scoreText.text = tempScore.ToString();
    }
    private int GetLocalScoreOfThisLevel()
    {
        return (GameObject.FindGameObjectWithTag("GameObject").transform.childCount-1) * 5;
    }

    public int GetScore()
    {
        return PlayerPrefs.GetInt("score") + GetLocalScoreOfThisLevel();
    }
}
