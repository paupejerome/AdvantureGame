using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpawn : MonoBehaviour {

    public GameObject spawn;
    public GameObject newSpawn;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            print("lol");
            spawn.transform.position = newSpawn.transform.position;
            spawn.transform.rotation = newSpawn.transform.rotation;
        }
    }
}
