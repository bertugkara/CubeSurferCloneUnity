using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GameObject" && SceneManager.GetSceneByName("Scenes/Level3").buildIndex != SceneManager.GetActiveScene().buildIndex )
        { // if player is successfull call the successScreen and print the current score
            PlayerPrefs.SetInt("score", ScoreManager.Instance.GetScore());
            PlayerPrefs.SetInt("CompletedLevel", SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene("Assets/Scenes/SuccessScreen.unity");
        }

         if (collision.gameObject.tag == "GameObject" && SceneManager.GetSceneByName("Scenes/Level3").buildIndex == SceneManager.GetActiveScene().buildIndex)
            // if it is the final level, do not call successscreen. call final screen
        {
            PlayerPrefs.SetInt("CompletedLevel", SceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.SetInt("score", ScoreManager.Instance.GetScore());
            SceneManager.LoadScene("Assets/Scenes/FinalScreen.unity");
        }

    }
}
