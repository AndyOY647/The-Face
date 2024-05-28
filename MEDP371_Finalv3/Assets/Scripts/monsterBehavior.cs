using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class monsterBehavior : MonoBehaviour
{
    //public variables
    public Transform player; // reference to the player's transform

    public float moveSpeed = 60f; 
    public float rotationSpeed = 5f; 


    public float changeTime;
    public string sceneName;

    //private variables
    private Animator animator;

    // Start is called before the first frame update
    
        
        
    private void Update()
    {
        if (transform.position.y < 0.5)
        {
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        }
        animator = GetComponent<Animator>();
        animator.SetBool("walking", false);
        Invoke("startWalking", 15);
        Invoke("ChasePlayer", 15); // method that holds the logic for enemy to chase player
        float distance = Vector3.Distance(player.position, transform.position);

        
    }
    void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    // Update is called once per frame
    private void startWalking()
    {
        animator.SetBool("walking", true);
    }
    private void ChasePlayer()
    {
            // calculate the direction towards the player
            Vector3 direction = (player.position - transform.position).normalized;

            // move the enemy towards the player
            transform.position += direction * moveSpeed*2 * Time.deltaTime;

            // calculate the rotation towards the player
            Quaternion lookRotation = Quaternion.LookRotation(direction);

            // smoothly rotate towards the player
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);

        }

    }
