using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherPuzzleChecker : MonoBehaviour
{
    public GameObject platform;
    public Animator PlatformNaik;

    private void Start()
    {
        PlatformNaik = GetComponent<Animator>();
    }

    private void Update()
    {
        if (PiringMerah.merahMatched == true && PiringIjo.ijoMatched == true)
        {
            PlatformNaik.Play("platformnaik");
            //Destroy(platform);
        }
    }
}
