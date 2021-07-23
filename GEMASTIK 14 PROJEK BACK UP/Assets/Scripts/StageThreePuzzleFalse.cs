using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageThreePuzzleFalse : MonoBehaviour
{
    public GameObject jawaban;
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
            jawaban.SetActive(true);
            Invoke("DestroyJawaban", 2);
        }
    }

    void DestroyJawaban()
    {
        jawaban.SetActive(false);
    }
}
