using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public GameObject landscape;
    public GameObject v;
    public GameObject v1;
    public GameObject v2;
    public GameObject v3;
    public GameObject v4;
    public GameObject v5;
    public GameObject v6;
    public GameObject timer;
    public GameObject success;
    public GameObject MacronPanel;
    public GameObject StudentIdPanel;

    //timer stuff
    private int time = 0;
    public Text timerr;
    public Text HighScore;
    public Text highScoreSuccess;
    private bool playing = true;
    private int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score Script active");
        //start timer
        time = 0;
        InvokeRepeating("IncrimentTime", 1, 1);


        //check if highscore exists and set the panel
        if (PlayerPrefs.HasKey("Highscore") == true)
        {
            currentScore = PlayerPrefs.GetInt("Highscore");

            HighScore.text = "Highscore: " + currentScore.ToString();
        }
        else
        {
            if (HighScore != null)
            {
                HighScore.text = "No HighScore";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if the villagers are active
        if (v.activeInHierarchy == false && v1.activeInHierarchy == false && v2.activeInHierarchy == false && v3.activeInHierarchy == false && 
            v4.activeInHierarchy == false && v5.activeInHierarchy == false && v6.activeInHierarchy == false && landscape.activeInHierarchy == true)
        {
            playing = false;
            timer.SetActive(false);
            success.SetActive(true);

            Destroy(MacronPanel);
            Destroy(StudentIdPanel);

            //stop timer
            CancelInvoke();
            SetHighscore();

            //set highscore
            if (currentScore > time)
            {
                SetHighscore();
                highScoreSuccess.text = "Highscore!! You are the best Reformer! Your time: " + time;
            }
            else
            {
                highScoreSuccess.text = "Not everyone is ment to be the best Reformer! Your time: " + time + " Highscore: " + currentScore.ToString();
            }
        }

    }

    public void SetHighscore()
    {

        {
            PlayerPrefs.SetInt("Highscore", time);
            HighScore.text = currentScore.ToString();
        }
    }

    public void ClearHighscores()
    {
        PlayerPrefs.DeleteKey("Highscore");
        HighScore.text = "No High Scores Yet";
    }

    public void IncrimentTime()
    {
        if (playing == true)
        {
            time += 1;
            timerr.text = "Time: " + time;
        }
    }

    public void RePlayGame()
    {
        Debug.Log("hola");
        success.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}

