using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steamdoors : MonoBehaviour {


    public GameObject block;
    public Transform bulletPrefab;
    
    private void Start()
    {
        Transform bullet = Instantiate(bulletPrefab) as Transform;
        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(block.GetComponent<Collider>(), GetComponent<Collider>());
    }
}
