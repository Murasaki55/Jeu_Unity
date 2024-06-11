using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonScript : MonoBehaviour
{
    Animator remyAnimator;
    AudioSource m_Source;
    [SerializeField] AudioClip m_Aie;
    // Start is called before the first frame update
    void Start()
    {
        remyAnimator = GetComponent<Animator>();
        m_Source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEntrer(Collision other)
    {
        Debug.Log("Trigger");
        if (other.gameObject.tag == "arbre")
        {
            m_Source.clip = m_Aie;
                    m_Source.Play();
            if (Input.GetKeyDown("e"))
            {
                remyAnimator.SetTrigger("lumbering");
            }
        }
        
        
    }
}
