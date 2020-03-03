using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_trigger : MonoBehaviour
{

    public GameObject macron;
    public AudioSource sourceMacron;
    public GameObject shootBtn;

    // Start is called before the first frame update
    void Start()
    {
        sourceMacron = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (macron.GetComponent<BoxCollider>().enabled == true)

            shootBtn.SetActive(true);

            if (sourceMacron.isPlaying == false)
            {

                Debug.Log("Play");
                sourceMacron.Play();
            }

    }
}
