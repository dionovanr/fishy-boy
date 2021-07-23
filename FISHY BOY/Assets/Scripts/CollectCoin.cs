using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{
    public ParticleSystem explosion;
    public AudioSource collectSound;

    private void Start()
    {
        //SkorManager.score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            SkorManager.score++;
            collectSound.Play();
            Destroy();
        }  
        
    }

    public void Destroy()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
