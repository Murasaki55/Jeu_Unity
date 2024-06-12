using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptplantation : MonoBehaviour
{
    // Start is called before the first frame update
    Animator remyAnimator;
    void Start()
    {
        int stade_plante = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger");
                  
            if ((Input.GetKeyDown("e"))&&(other.tag == "Plantation"))
            {
                remyAnimator.SetTrigger("plant");
                
                
            }
        
        
        
    }
    void OnTriggerEnter(Collider other)
    {
            
    
    }
    
}


