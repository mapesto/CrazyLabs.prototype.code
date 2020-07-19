using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{

    public GameObject Snowman;
    public ParticleSystem Particles;
    // Start is called before the first frame update
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
            DestroySnowman();
        }
    }
    private void DestroySnowman()
    {
        Particles.Play();
        Instantiate(Particles.gameObject, Snowman.transform.position, Quaternion.identity);

        Destroy(Snowman);
    }



}
