using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageThreeBalok1 : MonoBehaviour
{
    public static bool hijauMatched;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Balok Hijau")
        {
            hijauMatched = true;
        }
    }
}
