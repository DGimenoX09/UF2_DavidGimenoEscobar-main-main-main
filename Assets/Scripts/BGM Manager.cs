using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    AudioSource source;

    public AudioClip lvl1Music;

    public AudioClip victory;

    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Start()
    {
        source.clip = lvl1Music;
        source.Play();
    }

    void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
            {
                source.Stop();
                source.PlayOneShot(victory);
            } 
    }

}
