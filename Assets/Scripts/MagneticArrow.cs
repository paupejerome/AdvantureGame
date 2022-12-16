using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticArrow : MonoBehaviour {

    public float distanceStrenght = 10f;
    public float magnetStrenght = 5f;
    public float magnetDirection = 1; //- to repel, + to attract

    private Transform trans;
    private Rigidbody coinRb;
    private Transform coinTrans;
    public List<Transform> aggroList = new List<Transform>();
    private bool coinInZone = false;
    public bool looseMagnet = false;

    public bool attractActive = false;
    Rigidbody rb;

    private void Awake()
    {
        trans = transform;
        
    }


	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
		
	}
	


    private void FixedUpdate()
    {
        if (coinInZone)
        {
           
           
            //original : 3 below are removed
     

            for (int i = 0; i < aggroList.Count; i++)
            {
                Vector3 directionToMagnet = trans.position - (aggroList[i].position);
                float distance = Vector3.Distance(aggroList[i].position, trans.position);
                float magnetDistanceStr = (distanceStrenght / distance) * magnetStrenght;
                aggroList[i].GetComponent<Rigidbody>().AddForce(magnetDistanceStr * (directionToMagnet * magnetDirection), ForceMode.Force);
            }
            //coinRb.AddForce(magnetDistanceStr * (directionToMagnet * magnetDirection), ForceMode.Force);
          //  coinRb.AddForce((directionToMagnet * magnetDirection), ForceMode.Force);
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Coin" && attractActive)
        {
            if (aggroList.Contains(other.transform))
                return;
            aggroList.Add(other.transform);
            print("CoinAttracted");
            coinTrans = other.transform;
            coinInZone = true;
            //coinRb = other.GetComponent<Rigidbody>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Coin" && looseMagnet && attractActive)
        {


            coinInZone = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       // attractActive = true;
        if (collision.collider.tag == "Wood")
        {
            attractActive = true;
            rb.velocity = new Vector3(0, 0);
                rb.isKinematic = true;
            Invoke("Destroy", 3f);
        }
        rb.useGravity = true;
        Invoke("Destroy", 3f);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin" && attractActive)
        {
            print("CoinAttracted");
            coinTrans = other.transform;
            coinInZone = true;
            coinRb = other.GetComponent<Rigidbody>();

        }
    }

}
