using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steam : MonoBehaviour
{

    public bool isCoin;
    public GameObject electricWall;


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin") 
        {
            isCoin = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Coin")
        {
            isCoin = false;
        }
    }
    void Update()
    {

        if (isCoin == true)
        {
            electricWall.GetComponent<BoxCollider>().enabled = false;
            electricWall.GetComponent<MeshRenderer>().enabled = false;
        }

        if (isCoin == false)
        {
            electricWall.GetComponent<BoxCollider>().enabled = true;
            electricWall.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
