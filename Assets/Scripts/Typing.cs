using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Typing : MonoBehaviour {

    public Text textBox;
    static int health;

    public void Awake()
    {
        StartCoroutine(AnimateText());
    }

    public void Start()
    {
        health = 80;
    }

    string[] goatText = new string[] {
        "Initializing protocol: WAKE",
        "Good Morning Chance \n I'm currently running your vitals",
        "82.3% Current Health Quality \n Recommendation: \n Hydration Chamber",
        "Time til landing: 01:02:21"
    };
    int currentlyDisplayingText = 0;

    public void SkipToNextText()
    {
        StopAllCoroutines();
        currentlyDisplayingText++;
        if (currentlyDisplayingText > goatText.Length)
        {
            currentlyDisplayingText = 0;
        }
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        for (int i = 0; i < (goatText[currentlyDisplayingText].Length+1); i++)
        {
            textBox.text = goatText[currentlyDisplayingText].Substring(0, i);
            yield return new WaitForSeconds(.05f);
        }
    }
}