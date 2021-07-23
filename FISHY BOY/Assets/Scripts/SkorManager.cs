using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorManager : MonoBehaviour
{
    public GameObject scoreText;
    public static int score;

    //private void Awake()
    //{
    //    score = 0;
    //}

    void Update()
    {
       scoreText.GetComponent<Text>().text = "Score: " + score;   
        
    }
}
