using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float movementSpeed;
    private GameObject target;
    public GameObject spawn;
    private float damage = 34;



    void Update ()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
	}

   /* void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            target = other.gameObject;
            // Mettre le script avec la vie du player
            // target.GetComponent<PlayerScript>().health -=
            target.transform.position = spawn.transform.position;
        }
    }*/

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag  ("Player"))
        {
            target = col.gameObject;
            // Mettre le script avec la vie du player
            // target.GetComponent<PlayerScript>().health -=
            target.transform.position = spawn.transform.position;
            target.transform.rotation = spawn.transform.rotation;
        }
        Destroy(gameObject);
    }
}
