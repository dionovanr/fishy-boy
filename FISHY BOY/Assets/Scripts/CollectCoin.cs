using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{
    private void Start()
    {
        //SkorManager.score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag.Equals("Player"))
        {
            SkorManager.score += 1;
            Destroy(gameObject);
        }  
        
    }
}
