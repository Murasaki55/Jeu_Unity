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
    [SerializeField] GameObject wood;
    [SerializeField] GameObject grange;
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
                GameObject fireWood = Instantiate(wood);
                fireWood.transform.position = new Vector3(other.transform.position.x, 2.30F, other.transform.position.z);
            }
           
            if ((Input.GetKeyDown("e"))&&(other.tag == "firewood"))
            {
                remyAnimator.SetTrigger("plante");
                other.transform.position = new Vector3(35.74256F, 2.299947F, 164.9274F);
            }
        
        
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "axetrigg")
            {
                axe.SetActive(true);           
            }
        

       Debug.Log("colisition detecter");    
    
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "axetrigg")
            {
                axe.SetActive(false);           
            }
       Debug.Log("colisition sortie");
           
    }

}

