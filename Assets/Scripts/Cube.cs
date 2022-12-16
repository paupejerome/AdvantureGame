using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    Transform target;
    public Transform pointA;
    public Transform pointB;
    public bool up = false;
    public bool down = false;

    void Start()
    {
        target = pointB;
    }
    void Update()
    {
        if (up)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB.position, 2 * Time.deltaTime);
            if (Vector3.Distance(transform.position, pointB.position) < 0.1f)
            {
                target = pointA;
                up = false;
            }
        }
        if (down)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointA.position, 2 * Time.deltaTime);
            if (Vector3.Distance(transform.position, pointA.position) < 0.1f)
            {
                target = pointB;
                down = false;
            }
        }
    }
}
