using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDestroy : MonoBehaviour {

	public GameObject Target;


	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			
			Destroy (Target);
		}
	}
}
