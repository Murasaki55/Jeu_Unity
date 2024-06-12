using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class MonScript : MonoBehaviour
{

    public GameObject other;
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
    void OnCollisionEntrer()
    {
        Debug.Log("Trigger");
        
            m_Source.clip = m_Aie;
                    m_Source.Play();
            if (Input.GetKeyDown("e"))
            {
                remyAnimator.SetTrigger("lumbering");
            }
        
        
        
    }
}
