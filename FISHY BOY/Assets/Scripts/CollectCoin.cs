using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{
    public AudioSource collectSound;

    void Update()
    {
        

    }

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        SkorManager.score++;
        Destroy(gameObject);
        
    }
}
