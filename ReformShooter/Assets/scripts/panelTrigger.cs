using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelTrigger : MonoBehaviour
{

    public GameObject studentCard;
    public GameObject studentCardPanel;

    public GameObject macron;
    public GameObject macronPanel;
    private bool studentCardBool;

    // Update is called once per frame

    private void Start()
    {
        studentCardBool = false;
    }
    void Update()
    {
        if(studentCard.GetComponent<BoxCollider>().enabled == true)
        {
            studentCardBool = true;
        }
        else
        {
            studentCardBool = false;
        }

        //Check if Studentcard is enabled
        if (studentCardBool == true)
        {
            studentCardPanel.SetActive(false);
        }
        else
        {
            studentCardPanel.SetActive(true);
        }

        //Check if Macron is enabled
        if (macron.GetComponent<BoxCollider>().enabled == false && studentCardBool == true)
        {
            macronPanel.SetActive(true);
        }
        else
        {
            macronPanel.SetActive(false);
        }


    }
}
