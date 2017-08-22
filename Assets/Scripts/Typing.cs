using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Typing : MonoBehaviour {

    public Text textBox;
    static int health;
    public int counter;
    public Animator FadeOut;
    public Animator FadeIn;

    public void Awake()
    {
        StartCoroutine(AnimateText());
        Time.timeScale = 1;
        FadeOut.enabled = false;
        FadeIn.enabled = true;
    }

    public void Start()
    {
        FadeIn.Play("FadeIn");
        health = 80;
    }

    string[] goatText = new string[] {
        "Initializing protocol: WAKE",
        "Hello, please remain relaxed \n I'm currently running your vitals",
        "82.3% Current Health Quality \n Recommendation: \n Hydration Chamber",
        "Time til landing: 01:02:21"
    };
    int currentlyDisplayingText = 0;

    public void SkipToNextText()
    {
        StopAllCoroutines();
        currentlyDisplayingText++;
        counter += 1;
        if (counter == 4)
        {
            FadeOut.enabled = true;
            FadeOut.Play("FadeOut");
            StartCoroutine(Timer());
        }
        else
        {
            if (currentlyDisplayingText > goatText.Length)
            {
                currentlyDisplayingText = 0;
            }
            StartCoroutine(AnimateText());
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Ship");
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