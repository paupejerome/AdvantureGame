using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public GameObject turret;
    public float angle1;
    public float angle2;
    public float time;
    // private bool magnetised = false;
    // private bool isCoroutineExecuting = false;
    // Mettre une mesure de temps en privee

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Arrow")
        {
            // magnetised = true;
            turret.transform.rotation = Quaternion.Euler(0,angle1,0);
            Invoke("ReturnToNormalPosition", time); // Redemarer le "time"
        }
    }

    void ReturnToNormalPosition()
    {
        turret.transform.rotation = Quaternion.Euler(0, angle2, 0);
    }
}