using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamValve : MonoBehaviour {

    public GameObject text;
    public GameObject allSteam;
    public bool playerIsInside = false;



    public void Update()
    {
        if(playerIsInside)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                allSteam.SetActive(false);
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            text.SetActive(true);
            playerIsInside = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            text.SetActive(false);
            playerIsInside = false;
        }
    }
}
