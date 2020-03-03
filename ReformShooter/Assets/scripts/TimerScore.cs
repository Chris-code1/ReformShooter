using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScore : MonoBehaviour
{
    private int time = 0;
    public Text timerr;
    public Text HighScore;
    void Start()
    {
        if (PlayerPrefs.HasKey("Highscore") == true)
        {
            HighScore.text = "HighScore: " + PlayerPrefs.GetInt("Highscore").ToString() + " s";
        }
        else
        {
            if (HighScore != null)
            {
                HighScore.text = "No High Scores Yet";
            }
        }


        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "SampleScene")
        {
            Debug.Log("Hola");
            time = 0;
            InvokeRepeating("IncrimentTime", 1, 1);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Hola");
            CancelInvoke();

            if (PlayerPrefs.GetInt("Highscore") < time)
            {
                SetHighscore();
            }
        }
    }




    public void SetHighscore()
    {

        {
            PlayerPrefs.SetInt("Highscore", time);
            HighScore.text = PlayerPrefs.GetInt("Highscore").ToString();
        }
    }

    public void ClearHighscores()
    {
        PlayerPrefs.DeleteKey("Highscore");
        HighScore.text = "No High Scores Yet";
    }

    public void IncrimentTime()
    {
        time += 1;
        if (timerr != null)
        {
            timerr.text = "Time: " + time;
        }
    }
}