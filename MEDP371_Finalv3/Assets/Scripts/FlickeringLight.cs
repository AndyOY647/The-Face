using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // flickering delay
    public bool isFlickering = false;
    public float timeDelay;

    //flickering sound
    public AudioSource source;
    public AudioClip clip;

    // Update is called once per frame
    void Update()
    {
        if(isFlickering == false)
        {
            StartCoroutine(FlickeringLight());
        }
    }

    IEnumerator FlickeringLight() {
        isFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.1f, 0.3f);
        source.PlayOneShot(clip);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.1f, 0.3f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }

}// end of behavior
