using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightPickup : MonoBehaviour
{
    public GameObject inttext, flashlight_floor, flashlight_hand;
    public bool interactable;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }

    void Update()
    {
        if(interactable == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                inttext.SetActive(false);
                interactable = false;
                flashlight_hand.SetActive(true);
                flashlight_floor.SetActive(false);
            }
        }
    }
}
