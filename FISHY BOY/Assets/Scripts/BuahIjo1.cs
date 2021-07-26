using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuahIjo1 : MonoBehaviour
{
    public static bool buah1Matched;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Buah1")
        {
            buah1Matched = true;
        }
    }
}
