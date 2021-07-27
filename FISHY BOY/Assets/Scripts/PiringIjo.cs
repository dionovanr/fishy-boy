using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiringIjo : MonoBehaviour
{
    public static bool ijoMatched;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ijo")
        {

            ijoMatched = true;
        }
    }
}
