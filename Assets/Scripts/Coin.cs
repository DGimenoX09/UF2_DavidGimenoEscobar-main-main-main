using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour

{

private AudioSource source; 

public AudioClip coinSound;


    void Awake() 
    {
         source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collider)
        {
            if(collider.gameObject.tag == "Player")
            {
                source.PlayOneShot(coinSound);
                Destroy(gameObject, 0.5F);
            } 
        }
}
