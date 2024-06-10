using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEntrer(Collision other)
    {
        switch (other.gameObject.tag)
        {
        case "maison":
        break;

        case "arbre" :
        break;
        default:
            Debug.Log("rien");
            break;
        }
    }
}
