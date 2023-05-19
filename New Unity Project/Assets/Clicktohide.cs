using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMakeObjectDisappear : MonoBehaviour
{
    public GameObject objectToDisappear; // objecttodisappear is fire here 

    public GameObject waterobjectToHide;

    public GameObject doorclose ;
    private bool doorcls = false;

    private void OnMouseDown()
    {
        objectToDisappear.SetActive(false);
        Invoke("HideshowObject", 4);          // HideshowObject is water here
    }

    void HideshowObject()
    {
        waterobjectToHide.SetActive(true);
        Destroy(waterobjectToHide, 10);

        Invoke("doorHideshowObject", 10.1f);

        
        
    }

    void doorHideshowObject()
    {
        if (doorcls == false)
        {

            doorclose.SetActive(true);
        }

        else
        {
            doorclose.SetActive(false);
        }
    }


}

