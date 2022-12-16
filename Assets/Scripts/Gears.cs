using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gears : MonoBehaviour
{
    public GameObject gear1;
    public GameObject gear2;
    bool blue = false;
    bool red = false;

    void Update()
    {
        if(blue)
        {
            gear1.transform.Rotate(0, 1, 0);
            gear2.transform.Rotate(0, -1, 0);
            FindObjectOfType<Cube>().up = true;
            StartCoroutine(Active());
        }
        if (red)
        {
            gear1.transform.Rotate(0, -1, 0);
            gear2.transform.Rotate(0, 1, 0);
            FindObjectOfType<Cube>().down = true;
            StartCoroutine(Active());
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Blue")
        {
            blue = true;
        }
        if (other.tag == "Red")
        {
            red = true;
        }
    }
    IEnumerator Active()
    {
        yield return new WaitForSeconds(3);
        blue = false;
        red = false;
    }
}
