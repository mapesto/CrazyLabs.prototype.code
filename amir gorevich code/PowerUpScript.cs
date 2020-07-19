using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
   
    public ParticleSystem Particles;
    public GameObject Fish;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            
            DestroyFish();
        }
    }

    private void DestroyFish()
    {
        Destroy(gameObject);
        Particles.Play();
      
        Instantiate(Particles.gameObject, Fish.transform.position, Quaternion.identity);
    }
}

