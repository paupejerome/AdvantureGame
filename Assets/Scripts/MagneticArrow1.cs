using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticArrow1 : MonoBehaviour {

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

    public GameObject vfxBlue;
    public GameObject vfxRed;
    public GameObject vfxArrowRed;
    public GameObject vfxArrowBlue;


    bool entered = false;
    bool exited = false;

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
        if (collision.collider.tag == "Wood" && !entered)
        {
            print("Entered: " + collision.collider.name);
            attractActive = true;
            rb.velocity = new Vector3(0, 0);
                rb.isKinematic = true;

            if(Bow1.push == true)
            {
                vfxBlue.SetActive(true);
                vfxRed.SetActive(false);


            }

            if(Bow1.push == false)
            {
                
                vfxRed.SetActive(true);
                vfxBlue.SetActive(false);
                
            }
            entered = true;
            Invoke("Destroy", 3f);
        }
        print("woops");
        Invoke("Destroy", 3f);
        rb.useGravity = true;
    }

  /*  private void OnCollisionExit(Collision collision)
    {
        if(collision.collider.tag == "Wood" && !exited)
        {
            print("Exited: " + collision.collider.name);
            //rb.useGravity = true;
            //rb.isKinematic = false;
            //GetComponent<BoxCollider>().enabled = false;
            //exited = true;
        }
    }*/
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

    private void Update()
    {
       
    }

}
