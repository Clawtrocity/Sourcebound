using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ship : MonoBehaviour
{
    public Animator RoomSelection;
    public bool RoomSelected;
    public Text RoomTitle;
    public Text Button1;
    public Text Button2;
    public Text Button3;
    public Text Button4;
    public string rt;
    public string b1;
    public string b2;
    public string b3;
    public string b4;

    public void Awake()
    {
        RoomSelection.enabled = false;
    }

    public void HydrationChamber()
    {
        rt = "Hydration Chamber";
        b1 = "Heal";
        b2 = "Test";
        b3 = "got em";
        b4 = "heh";
        RoomSelection.enabled = true;
        if (RoomSelected == false)
        {
            RoomSelection.Play("RoomSelection");
            RoomTitle.text = rt;
            Button1.text = b1;
            Button2.text = b2;
            Button3.text = b3;
            Button4.text = b4;
        }
        else
        {
            RoomSelection.Play("RoomSelectionOut");
            StartCoroutine(Timer(1));
        }
        RoomSelected = true;
    }

    public void Labratory()
    {
        rt = "Labratory";
        b1 = "Research";
        b2 = "Experiment";
        b3 = "Something";
        b4 = "Buttsoup";
        RoomSelection.enabled = true;
        if (RoomSelected == false)
        {
            RoomSelection.Play("RoomSelection");
            RoomTitle.text = rt;
            Button1.text = b1;
            Button2.text = b2;
            Button3.text = b3;
            Button4.text = b4;
        }
        else
        {
            RoomSelection.Play("RoomSelectionOut");
            StartCoroutine(Timer(1));
        }
        RoomSelected = true;
    }

    public void Cargo()
    {
        rt = "Hydration Chamber";
        b1 = "Heal";
        b2 = "Test";
        b3 = "got em";
        b4 = "heh";
        RoomSelection.enabled = true;
        if (RoomSelected == false)
        {
            RoomSelection.Play("RoomSelection");
            RoomTitle.text = rt;
            Button1.text = b1;
            Button2.text = b2;
            Button3.text = b3;
            Button4.text = b4;
        }
        else
        {
            RoomSelection.Play("RoomSelectionOut");
            StartCoroutine(Timer(1));
        }
        RoomSelected = true;
    }

    public void Workshop()
    {
        rt = "Hydration Chamber";
        b1 = "Heal";
        b2 = "Test";
        b3 = "got em";
        b4 = "heh";
        RoomSelection.enabled = true;
        if (RoomSelected == false)
        {
            RoomSelection.Play("RoomSelection");
            RoomTitle.text = rt;
            Button1.text = b1;
            Button2.text = b2;
            Button3.text = b3;
            Button4.text = b4;
        }
        else
        {
            RoomSelection.Play("RoomSelectionOut");
            StartCoroutine(Timer(1));
        }
        RoomSelected = true;
    }

    public void CrewQuarters()
    {
        rt = "Hydration Chamber";
        b1 = "Heal";
        b2 = "Test";
        b3 = "got em";
        b4 = "heh";
        RoomSelection.enabled = true;
        if (RoomSelected == false)
        {
            RoomSelection.Play("RoomSelection");
            RoomTitle.text = rt;
            Button1.text = b1;
            Button2.text = b2;
            Button3.text = b3;
            Button4.text = b4;
        }
        else
        {
            RoomSelection.Play("RoomSelectionOut");
            StartCoroutine(Timer(1));
        }
        RoomSelected = true;
    }

    public void Engine()
    {
        rt = "Hydration Chamber";
        b1 = "Heal";
        b2 = "Test";
        b3 = "got em";
        b4 = "heh";
        RoomSelection.enabled = true;
        if (RoomSelected == false)
        {
            RoomSelection.Play("RoomSelection");
            RoomTitle.text = rt;
            Button1.text = b1;
            Button2.text = b2;
            Button3.text = b3;
            Button4.text = b4;
        }
        else
        {
            RoomSelection.Play("RoomSelectionOut");
            StartCoroutine(Timer(1));
        }
        RoomSelected = true;
    }

    public void Bridge()
    {
        rt = "Hydration Chamber";
        b1 = "Heal";
        b2 = "Test";
        b3 = "got em";
        b4 = "heh";
        RoomSelection.enabled = true;
        if (RoomSelected == false)
        {
            RoomSelection.Play("RoomSelection");
            RoomTitle.text = rt;
            Button1.text = b1;
            Button2.text = b2;
            Button3.text = b3;
            Button4.text = b4;
        }
        else
        {
            RoomSelection.Play("RoomSelectionOut");
            StartCoroutine(Timer(1));
        }
        RoomSelected = true;
    }

    public void HibernationPods()
    {
        rt = "Hydration Chamber";
        b1 = "Heal";
        b2 = "Test";
        b3 = "got em";
        b4 = "heh";
        RoomSelection.enabled = true;
        if (RoomSelected == false)
        {
            RoomSelection.Play("RoomSelection");
            RoomTitle.text = rt;
            Button1.text = b1;
            Button2.text = b2;
            Button3.text = b3;
            Button4.text = b4;
        }
        else
        {
            RoomSelection.Play("RoomSelectionOut");
            StartCoroutine(Timer(1));
        }
        RoomSelected = true;
    }

    IEnumerator Timer(int value)
    {
        RoomSelected = false;
        yield return new WaitForSeconds(value);
        RoomSelection.Play("RoomSelection");
        RoomTitle.text = rt;
        Button1.text = b1;
        Button2.text = b2;
        Button3.text = b3;
        Button4.text = b4;
    }

    public void BT1()
    {
        if(rt == "Hydration Chamber")
        {
            Button1.text = "Healed";
        }
        if (rt == "Labratory")
        {
            Button1.text = "Herp";
        }
    }
    public void BT2()
    {
        if (rt == "Hydration Chamber")
        {
            Button2.text = "Healed";
        }
        if (rt == "Labratory")
        {
            Button2.text = "Herp";
        }
    }

    public void BT3()
    {
        if (rt == "Hydration Chamber")
        {
            Button3.text = "Healed";
        }
        if (rt == "Labratory")
        {
            Button3.text = "Herp";
        }
    }

    public void BT4()
    {
        if (rt == "Hydration Chamber")
        {
            Button4.text = "Healed";
        }
        if (rt == "Labratory")
        {
            Button4.text = "Herp";
        }
    }
}