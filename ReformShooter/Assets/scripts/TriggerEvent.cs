using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public GameObject explosion;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered");
        gameObject.SetActive(false);
        GameObject go = Instantiate(explosion, gameObject.transform.position, transform.rotation);
        Handheld.Vibrate();
    }
}
