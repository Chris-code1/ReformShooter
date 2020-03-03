using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour

{
    public Text counterText;
    public float  startTime;
    private bool finished = false; 


    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "SampleScene")

        startTime = Time.time;
    //{
    //        Scene scene = SceneManager.GetActiveScene();
    //    if (scene.name == "Menu")
    //        counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");

    }

    // Update is called once per frame
    void Update()

    {if (finished)
            return;

        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = ((t%60)).ToString("f0");
        counterText.text = minutes + ":" + seconds;


        //Scene scene = SceneManager.GetActiveScene();



        //if (scene.name == "SampleScene")

        //{
        //    Debug.Log("Hola");
        //    counterText = GetComponent<Text>() as Text;
        //    minutes = (int)(Time.time / 60f);
        //    seconds = (int)(Time.time % 60f);
        //    counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
    }

