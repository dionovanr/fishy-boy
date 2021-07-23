using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleKeyRotate : MonoBehaviour
{
    public GameObject Gerbang;
    public static  bool Benar;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Benar")
        {
            Benar = true;
           
            Gerbang.SetActive(false);
        }
    }
}
