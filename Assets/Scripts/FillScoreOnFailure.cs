using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FillScoreOnFailure : MonoBehaviour
{

    public TextMeshProUGUI text;

    void Start()
    {
        text.text ="Score: " +  PlayerPrefs.GetInt("score").ToString();
    }

   
}
