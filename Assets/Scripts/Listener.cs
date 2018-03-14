using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    public AudioSource audi;
    public AudioClip audiclp;
    [SerializeField]
    private float vol = 1f;


    void Awake()
    {
        audi = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        audi.Stop();
        audi.PlayOneShot(audiclp, vol);
        print("deberia sonar");

    }


   private void  OnTriggerExit(Collider Other)
    {
        audi.Stop();


    }
}