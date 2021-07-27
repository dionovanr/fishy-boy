using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiringMerah : MonoBehaviour
{
    public static bool merahMatched;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Merah")
        {
            merahMatched = true;
        }
    }
}
