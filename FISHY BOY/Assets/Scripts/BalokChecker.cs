using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalokChecker : MonoBehaviour
{
    public GameObject Gerbang;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StageThreeBalok1.hijauMatched == true && BalokBiru.biruMatched == true && BalokRektor.rektorMatched == true)
        {
            Destroy(Gerbang);
        }
    }
}
