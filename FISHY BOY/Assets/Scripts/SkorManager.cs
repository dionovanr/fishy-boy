using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorManager : MonoBehaviour
{
    public GameObject scoreText;
    public static int score = 0;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }
}
