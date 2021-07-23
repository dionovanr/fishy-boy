using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageThreePuzzleTrue : MonoBehaviour
{
    public GameObject Jawaban, Gerbang;

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
        if (col.gameObject.tag == "Player")
        {
            Jawaban.SetActive(true);
            Gerbang.SetActive(false);
        }
    }
}
