using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody rb;
    [HideInInspector] public float force = 1500f;
    [HideInInspector] public float damage = 20;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.down * force);
        Destroy(gameObject, 3f);
    }
}
