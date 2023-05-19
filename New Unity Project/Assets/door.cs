using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOnClick : MonoBehaviour
{
    public Animator animation; // to access door animation froma animator window
    public GameObject door;    // to access the door rotation 
   


    private void Start()
    {
        animation = door.GetComponent<Animator>();
    }

    

    public void OnMouseUpAsButton()
    {
        animation.SetTrigger("TrClose");
        Debug.Log("close door");
       
            
           
            

           
        
    }
}
