using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bow : MonoBehaviour
{
 //  Transform socket;
  //  [SerializeField] Transform hipSocket;
   // [SerializeField] Transform sightSocket;
    public GameObject arrow;
   // float arrowSpeed = 500f;
    public bool push = true;

   // public Image magneticIndicator;

    public int arrowCount = 0;


   /* void Awake()
    {
        socket = transform.Find("Socket");
    }*/

  /*  private void Start()
    {
        magneticIndicator.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
    }*/

    public void Fire()
    {
            
       
        if ( push)
        {
            //  arrowCount++;
            GameObject lastarrow = arrow;
            lastarrow.GetComponent<MagneticArrow>().magnetDirection = 1;
         //   lastarrow.GetComponent<Arrow>().force = arrowSpeed;
         //   Invoke("LowerCount", 3f);

        }
        else if(push == false)
        {
            GameObject lastarrow = arrow;
            lastarrow.GetComponent<MagneticArrow>().magnetDirection = -1;
          //  lastarrow.GetComponent<Arrow>().force = arrowSpeed;
          //  Invoke("LowerCount", 3f);
        }
       // Invoke("LowerCount", 3f);
    }
  /*  public void AimUp()
    {
        iTween.MoveUpdate(this.gameObject, sightSocket.position, 0.4f);
        iTween.RotateUpdate(this.gameObject, sightSocket.rotation.eulerAngles, 0.4f);
    }
    public void AimDown()
    {
        iTween.MoveUpdate(this.gameObject, hipSocket.position, 0.4f);
        iTween.RotateUpdate(this.gameObject, hipSocket.rotation.eulerAngles, 0.4f);
    }

    public void LowerCount()
    {
        arrowCount--;
    }*/
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            push = true;
            Fire();
         //   magneticIndicator.GetComponent<Image>().color = new Color32(255, 0, 0, 255);

        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            push = false;
            Fire();
            print("pushed");
          //  magneticIndicator.GetComponent<Image>().color = new Color32(0, 149, 255, 255);

        }
    }

}
