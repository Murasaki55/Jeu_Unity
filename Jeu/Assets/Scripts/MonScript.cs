using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    [SerializeField] GameObject carrote;
    [SerializeField] GameObject aubergine;
    [SerializeField] GameObject mais;
    [SerializeField] GameObject navet;
    [SerializeField] GameObject tomate;
    [SerializeField] GameObject citrouille;
    [SerializeField] GameObject WoodCrate;
    [SerializeField] GameObject caillou;
    [SerializeField] GameObject cristal;
    [SerializeField] Text m_Score_bois;
    [SerializeField] Text m_Score_caisse;
    [SerializeField] Text m_Score_pierre;
    [SerializeField] Text m_Score_cristal;
    [SerializeField] Text Victoire;


    public bool plantactive;

    private int scoreb;
    private int scorel;
    private int scorep;
    private int scorec;

    
    // Start is called before the first frame update
    void Start()
    {
        remyAnimator = GetComponent<Animator>();
        m_Source = GetComponent<AudioSource>();
        axe.SetActive(false);
        pickaxe.SetActive(false);
        carrote.SetActive(false);
        aubergine.SetActive(false);
        mais.SetActive(false);
        navet.SetActive(false);
        tomate.SetActive(false);
        citrouille.SetActive(false);
        plantactive = false;

        scoreb = 0;
        scorel = 0;
        scorep = 0;
        scorec = 0;
        m_Score_bois.text = scoreb.ToString() + " /10";
        m_Score_caisse.text = scorel.ToString()+ " /10";
        m_Score_pierre.text = scorep.ToString()+ " /10";
        m_Score_cristal.text = scorec.ToString()+ " /10";
    
    }

    // Update is called once per frame
    void Update()
    {
        if(((Input.GetKeyDown("w"))&&(Input.GetKeyDown("i")))&&(Input.GetKeyDown("n"))){
            scoreb = 10;
            scorel = 10;
            scorep = 10;
            scorec = 10;
        }
       m_Score_bois.text = scoreb.ToString() + " /10";
        m_Score_caisse.text = scorel.ToString()+ " /10";
        m_Score_pierre.text = scorep.ToString()+ " /10";
        m_Score_cristal.text = scorec.ToString()+ " /10"; 
        if((( scoreb == 10)&&(scorel == 10))&&((scorep == 10)&&( scorec == 10))){
            win();
        }
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
                scoreb++;
            }
            if (((Input.GetKeyDown("e"))&&(other.tag == "Plantation"))&&(plantactive == false))
            {
                remyAnimator.SetTrigger("plante");
                carrote.SetActive(true);
                aubergine.SetActive(true);
                mais.SetActive(true);
                navet.SetActive(true);
                tomate.SetActive(true);
                citrouille.SetActive(true);
                plantactive=true;
            }else{
                if (((Input.GetKeyDown("e"))&&(other.tag == "Plantation"))&&(plantactive == true)){
                    remyAnimator.SetTrigger("plante");
                    carrote.SetActive(false);
                    aubergine.SetActive(false);
                    mais.SetActive(false);
                    navet.SetActive(false);
                    tomate.SetActive(false);
                    citrouille.SetActive(false);
                    plantactive=false;
                    GameObject caisselegume = Instantiate(WoodCrate);
                    caisselegume.transform.position = new Vector3(192, 4, 60);
                    scorel++;
                    } 
            }
            if ((Input.GetKeyDown("e"))&&(other.tag == "roche"))
            {
                
                remyAnimator.SetTrigger("pickaxe");
                GameObject pierre = Instantiate(caillou);
                pierre.transform.position = new Vector3(232.6283F, 2.667977F, 116.6443F);
                scorep++;
            }
            if ((Input.GetKeyDown("e"))&&(other.tag == "cristaux"))
            {
                
                remyAnimator.SetTrigger("pickaxe");
                GameObject cristaux = Instantiate(cristal);
                cristaux.transform.position = new Vector3(232.0249F, 2.474069F, 111.314F);
                scorec++;
            }
        
        
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "axetrigg")
            {
                axe.SetActive(true);           
            }
        if (other.tag == "pickaxetrigg")
            {
                pickaxe.SetActive(true);           
            }
        if (other.tag == "mura")
        {
            
        }

       Debug.Log("colisition detecter");    
    
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "axetrigg")
            {
                axe.SetActive(false);           
            }
        if (other.tag == "pickaxetrigg")
            {
                pickaxe.SetActive(false);           
            }
       Debug.Log("colisition sortie");
           
    }
    void win()
    {
        transform.position = new Vector3(123.9F, 2.3F, 307.5F);
        Victoire.text = "Felicitation";
    }

}

