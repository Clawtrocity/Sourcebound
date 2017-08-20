using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

    public Animator anim;

    public void Start()
    {
        Time.timeScale = 0;
        anim.enabled = false;
    }

    public void PlayButton()
    {
        Time.timeScale = 1;
        anim.enabled = true;
        StartCoroutine(Timer());
        anim.Play("FadeOut");
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Intro");
    }
}
