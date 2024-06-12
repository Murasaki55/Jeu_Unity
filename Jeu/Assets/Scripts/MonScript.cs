using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class MonScript : MonoBehaviour
{

    
    Animator remyAnimator;
    AudioSource m_Source;
    [SerializeField] AudioClip m_Aie;
    [SerializeField] GameObject axe;
    [SerializeField] GameObject pickaxe;
    // Start is called before the first frame update
    void Start()
    {
        remyAnimator = GetComponent<Animator>();
        m_Source = GetComponent<AudioSource>();
        axe.SetActive(false);
        pickaxe.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger");
                  
            if ((Input.GetKeyDown("e"))&&(other.tag == "arbre"))
            {
                
                remyAnimator.SetTrigger("lumbering");
                other.transform.position = new Vector3(other.transform.position.x, -100, other.transform.position.z);
                
            }
        
        
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "arbre")
            {
                axe.SetActive(true);
            {
            }
       Debug.Log("colisition detecter");
            m_Source.clip = m_Aie;
              m_Source.Play();      
    
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "arbre")
            {
                axe.SetActive(false);
            }
       Debug.Log("colisition sortie");
           
    }


}
}
