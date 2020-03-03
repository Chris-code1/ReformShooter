using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHighscore : MonoBehaviour
{
    public Text HighScore;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Highscore") == true)
        {
            HighScore.text = "Highscore: " + PlayerPrefs.GetInt("Highscore").ToString();
        }
        else
        {
            if (HighScore != null)
            {
                HighScore.text = "No High Scores";
            }
        }

    }
}
