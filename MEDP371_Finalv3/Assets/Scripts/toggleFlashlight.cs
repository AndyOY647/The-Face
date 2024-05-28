using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleFlashlight : MonoBehaviour
{
    public GameObject lightBeam;
    public bool toggle;
    public AudioSource toggleSound;

    void Start()
    {
        if(toggle == false)
        {
            lightBeam.SetActive(false);
        }
        if(toggle == true)
        {
            lightBeam.SetActive(true);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            toggleSound.enabled = true;
            
            toggle = !toggle;
            if(toggle == false)
            {
                lightBeam.SetActive(false);
            }
            if(toggle == true)
            {
                lightBeam.SetActive(true);
            }
        }
        else
        {
            toggleSound.enabled = false;
        }
    }
}
