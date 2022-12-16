﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathtrigger : MonoBehaviour {

    private GameObject player;
    public GameObject spawn;
    void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
            print("yo");
            player = GameObject.FindWithTag("Player");
            // Player entered red zone, reload game.
            //Application.LoadLevel(0);
            player.transform.position = spawn.transform.position;
            player.transform.rotation = spawn.transform.rotation;
		}
	}
}