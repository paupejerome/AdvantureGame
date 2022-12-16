using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMove : MonoBehaviour {

    public SplineInterpolator SplineInterpolatorComponent;


    private void Start()
    {
        SplineInterpolatorComponent.SetStopped();
    }

    private void OnTriggerEnter(Collider other)
	{

		if (other.tag == "Rock") 
		{
			SplineInterpolatorComponent.SetStopped ();
		}

       
		if (other.tag == "Player")
        {
            SplineInterpolatorComponent.SetUnstop();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            SplineInterpolatorComponent.SetStopped();
        }
    }
}
