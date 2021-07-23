using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void Start()
    {
        GameObject trigger = GameObject.FindWithTag("PlatformGerak");
        trigger.GetComponent<MovingPlatform>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Balok" || other.gameObject.tag == "Player")
        {
            GameObject trigger = GameObject.FindWithTag("PlatformGerak");
            trigger.GetComponent<MovingPlatform>().enabled = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Balok" || other.gameObject.tag == "Player")
        {
            GameObject trigger = GameObject.FindWithTag("PlatformGerak");
            trigger.GetComponent<MovingPlatform>().enabled = false;
        }
       
    }


}
