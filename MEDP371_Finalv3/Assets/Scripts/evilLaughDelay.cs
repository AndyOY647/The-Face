using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilLaughDelay : MonoBehaviour
{
    public AudioSource evilLaugh;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(laughingDelay());
    }

    private IEnumerator laughingDelay()
    {
        yield return new WaitForSeconds(15);
        evilLaugh.enabled = true;
        evilLaugh.Play();
        
    }
   
}
