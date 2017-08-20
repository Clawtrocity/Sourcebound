using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {
    public Animator anim;

	// Use this for initialization
	void Start ()
    {
        Time.timeScale = 1;
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(16);
        SceneManager.LoadScene("Game");
        SceneManager.UnloadSceneAsync("Intro");
    }
}
