using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    float timer = 0;
    bool timerReached = false;
    public AudioSource source;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Shoot Script Active");
    }
    public GameObject bulletPrefab;
    public Transform spawnObject;

    // Update is called once per frame
    /*
    void Update()
    {
        if (!timerReached)
            timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && !timerReached && timer > 1)
        {
            Debug.Log("Done waiting");
            fire();

            //Set to false so that We don't run this again
            timer = 0;
        }
    }
    */
    public void Fire()
    {
        GameObject go = Instantiate(bulletPrefab, spawnObject.position, transform.rotation) as GameObject;
        go.GetComponent<Rigidbody>().AddForce(transform.forward * 15, ForceMode.Impulse);
        source.Play();
    }
}
