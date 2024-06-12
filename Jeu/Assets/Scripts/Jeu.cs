using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jeu : MonoBehaviour
{
    public string nomDeScene;
    // Start is called before the first frame update
    public void AllerAuNiveau()
    {
        SceneManager.LoadScene(nomDeScene);
    }

    // Update is called once per frame
    private void OnTriggerEntrer(Collider other)
    {
        AllerAuNiveau();
    }
}
