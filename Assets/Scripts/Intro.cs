using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour {
    public Animation open;
    public int counter;

	// Use this for initialization
	void Start ()
    {
        Time.timeScale = 0;
        Animation();
    }
	
	// Update is called once per frame
	void Update ()
    {
        counter += 1;
	}

    public void Animation()
    {
        if (counter == 200)
        {
            open.PlayQueued("Intro1", QueueMode.PlayNow);
            open.PlayQueued("Outro1", QueueMode.CompleteOthers);
        }

        if (counter == 600)
        {
            open.PlayQueued("Intro2", QueueMode.CompleteOthers);
            open.PlayQueued("Outro2", QueueMode.CompleteOthers);
        }

        if (counter == 1300)
        {
            open.PlayQueued("Intro3", QueueMode.CompleteOthers);
            open.PlayQueued("Outro3", QueueMode.CompleteOthers);
        }

        if (counter == 2000)
        {
            open.PlayQueued("Intro4", QueueMode.CompleteOthers);
            open.PlayQueued("Outro4", QueueMode.CompleteOthers);
        }
    }
}
