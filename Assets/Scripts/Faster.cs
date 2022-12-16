using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faster : MonoBehaviour {

    public GameObject steam;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            steam.GetComponent<SetParent>().smooth = 0.06f; 
        }
    }
}
