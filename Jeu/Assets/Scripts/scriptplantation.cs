using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptplantation : MonoBehaviour
{
     public int planterdm;
    [SerializeField] GameObject dirt_pile;
    [SerializeField] GameObject carrot_plant;
    [SerializeField] GameObject corn_plant;
    [SerializeField] GameObject eggplant_plant;
    [SerializeField] GameObject pumpkin_plant;
    [SerializeField] GameObject tomato_plant;
    [SerializeField] GameObject turnip_plant;
    [SerializeField] GameObject carrot_fruit;
    [SerializeField] GameObject corn_fruit;
    [SerializeField] GameObject eggplant_fruit;
    [SerializeField] GameObject pumpkin_fruit;
    [SerializeField] GameObject tomato_fruit;
    [SerializeField] GameObject turnip_fruit;
    public GameObject[] planttab = new string[] {carrot_plant, corn_plant, eggplant_plant, pumpkin_plant, tomato_plant, turnip_plant};
     public GameObject[] fruittab = new string[] {carrot_fruit, corn_fruit, eggplant_fruit, pumpkin_fruit, tomato_fruit, turnip_fruit};
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
                  
            if ((Input.GetKeyDown("e"))&&(other.tag == "Player"))
            {
                remyAnimator.SetTrigger("plante");
                if (stade_plant == 0){
                   plantrdm = Random.Range(0,6);
                   GameObject plante = Instantiate(planttab[plantrdm]);
                   stade_plante +=1;
                }
                if(stade_plant == 1){
                    GameObject plante = Instantiate(fruittab[plantrdm]);
                   stade_plante +=1;
                }
                other.transform.position = new Vector3(other.transform.position.x, -100, other.transform.position.z);
                GameObject fireWood = Instantiate(wood);
                fireWood.transform.position = new Vector3(other.transform.position.x, 1+3/2, other.transform.position.z);
            }
            if ((Input.GetKeyDown("e"))&&(other.tag == "Plantation"))
            {
                remyAnimator.SetTrigger("plante");
            }
    }
    
}


