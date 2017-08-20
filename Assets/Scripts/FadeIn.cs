using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour {

    public Animator anim;

    public void Start()
    {
        Time.timeScale = 1;
        anim.enabled = true;
        anim.Play("FadeIn");
    }
}
