using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuahIjo2 : MonoBehaviour
{
    public static bool buah3Matched;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Buah3")
        {
            buah3Matched = true;
        }
    }
}
