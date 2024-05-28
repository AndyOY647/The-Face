using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class delayBeforeDeath : MonoBehaviour
{
    public GameObject jumpcam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(jumpcam.activeSelf){
            Invoke("cameraDisabled", 5);
            
        }
        Invoke("loadDeath", 5);
    }

    void cameraDisabled(){
        jumpcam.SetActive(false);
        
    }

    void loadDeath(){
        SceneManager.LoadScene("DeathScreen");
    }
}
