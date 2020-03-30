/*
 * Kevon Long
 * ScoreAndTime.cs
 * Assignment #5
 * Sets the score in the text and counts the timer down to switch scenes
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreAndTime : MonoBehaviour
{
    public Text timer;
    public Text scoreText;
    public float time;

    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        time = 30;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timer.text = "" + time;

        scoreText.text = "Your score: " + score;

        if(time <= 0.0f)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
