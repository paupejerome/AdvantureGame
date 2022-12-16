using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bow1 : MonoBehaviour
{
    [HideInInspector]
    public GameObject lastArrow;

   [SerializeField]
   static public bool push = true;

    public GameObject vfxArrowRed;
    public GameObject vfxArrowBlue;
    public GameObject vfxLampRed;
    public GameObject vfxLampBlue;
    public GameObject glass;
    
   

    public GameObject trueLastArrow;
  

    public int arrowCount = 0;

    private void Start()
    {
        trueLastArrow.GetComponent<MagneticArrow1>().magnetDirection = 1f;
        vfxLampBlue.SetActive(true);
        VfxBlue();

    }


    public void SetVFXColor()
    {
        if (push)
        {
            trueLastArrow.GetComponent<MagneticArrow1>().magnetDirection = 1f;
            trueLastArrow.GetComponent<MagneticArrow1>().vfxArrowRed.SetActive(false);
            trueLastArrow.GetComponent<MagneticArrow1>().vfxArrowBlue.SetActive(true);
           
           // if (lastArrow != null)
            
               
              //  lastArrow.GetComponent<MagneticArrow1>().magnetDirection = 1f;
               // lastArrow.GetComponent<MagneticArrow1>().vfxArrowBlue.SetActive(true);
                //lastArrow.GetComponent<MagneticArrow1>().vfxArrowRed.SetActive(false);
      
            
                   
        }
        else if(push == false)
        {
            trueLastArrow.GetComponent<MagneticArrow1>().magnetDirection = -1f;
            trueLastArrow.GetComponent<MagneticArrow1>().vfxArrowBlue.SetActive(false);
            trueLastArrow.GetComponent<MagneticArrow1>().vfxArrowRed.SetActive(true);
            
        //    if (lastArrow != null) { 
          
                
                //  lastArrow.GetComponent<MagneticArrow1>().magnetDirection = -1f;
                //lastArrow.GetComponent<MagneticArrow1>().vfxArrowRed.SetActive(true);
               // lastArrow.GetComponent<MagneticArrow1>().vfxArrowBlue.SetActive(false);
        
                   
        }
       
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            push = true;
            SetVFXColor();
            VfxBlue();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            push = false;
            SetVFXColor();
            VfxRed();
        }
    }

    private void VfxBlue()
    {
        vfxLampRed.SetActive(false);
        vfxLampBlue.SetActive(true);
        glass.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", new Color32(84,125,159,255));



    }

    private void VfxRed()
    {
        
        vfxLampRed.SetActive(true);
        vfxLampBlue.SetActive(false);
        glass.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", new Color32(131, 16, 16, 255));

    }
}
