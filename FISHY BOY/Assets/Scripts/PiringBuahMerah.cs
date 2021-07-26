using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiringBuahMerah : MonoBehaviour
{
    public static bool buah2Matched;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Buah2")
        {
            buah2Matched = true;
        }
    }
}
