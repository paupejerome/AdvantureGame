using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmokeDamage : MonoBehaviour
{
    public GameObject smoke001;
    public GameObject smoke002;
    public GameObject smoke003;
    public GameObject player;
    public GameObject spawn;
    private bool smoke1;
    private bool smoke2;
    private bool smoke3;


    void Update()
    {
        if(smoke1 == true)
        {
            smoke001.SetActive(true);
        }

        if(smoke2 == true)
        {
            //smoke001.SetActive(false);
            smoke002.SetActive(true);
        }

        if (smoke3 == true)
        {
           // smoke002.SetActive(false);
            smoke003.SetActive(true);
        }
    }






    private void OnTriggerStay(Collider other)
    {
        if(other.tag == ("Player"))
        {
            StartCoroutine("Dps");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == ("Player"))
        {
            StopCoroutine("Dps");
        }
    }

    IEnumerator Dps()
    {
       
        yield return new WaitForSeconds(1);
        smoke1 = true;
        Debug.Log("1 degat");
        yield return new WaitForSeconds(1);
        smoke2 = true;
        Debug.Log("2 degats");
        yield return new WaitForSeconds(1);
        smoke3 = true;   
        Debug.Log("3 degats");
        yield return new WaitForSeconds(1);
        player.transform.position = spawn.transform.position;
        smoke1 = false;
        smoke2 = false;
        smoke3 = false;
        smoke001.SetActive(false);
        smoke002.SetActive(false);
        smoke003.SetActive(false);
        yield return new WaitForSeconds(2);

    }
}
