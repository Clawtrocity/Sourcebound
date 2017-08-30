using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ship : MonoBehaviour
{
    public Animator RoomSelection;
    public Animator Fade;
    public Animator EventScreen;
    public Animator EventBG;
    public Animator NotificationAnim;
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
    public int EventChoice;
    public Text EventTitle;
    public Text EventBody;
    public Text EventButton1;
    public Text EventButton2;
    public Text Notification;
    public int placeholder;

    public void Awake()
    {
        RoomSelection.enabled = false;
        EventScreen.enabled = false;
        EventBG.enabled = false;
        NotificationAnim.enabled = false;
        Fade.enabled = false;
    }

    public void Start()
    {
        Fade.enabled = true;
        Fade.Play("FadeIn");
    }
    
    public void HydrationChamber()
    {
        rt = "Hydration Chamber";
        b1 = "Hydate";
        b2 = "Memory Download";
        b3 = "Relax";
        b4 = "Store Biomatter";
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
        b1 = "Experiment";
        b2 = "Research";
        b3 = "Study";
        b4 = "Diagnose";
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
        rt = "Cargo";
        b1 = "Exit";
        b2 = "Check Cargo";
        b3 = "Jettison Block";
        b4 = "Upgrade";
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
        rt = "Workshop";
        b1 = "Build";
        b2 = "Research";
        b3 = "Study";
        b4 = "Repair";
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
        rt = "Crew";
        b1 = "Sleep";
        b2 = "Eat";
        b3 = "Relax";
        b4 = "Exercise";
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
        rt = "Engine";
        b1 = "Check Engine";
        b2 = "Add Fuel";
        b3 = "Upgrade";
        b4 = "Repair";
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
        rt = "Bridge";
        b1 = "Depart";
        b2 = "Navigation";
        b3 = "Mission Objectives";
        b4 = "Ship Status";
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
        rt = "Hibernation";
        b1 = "Hibernate";
        b2 = "Check Pods";
        b3 = "Wake Up";
        b4 = "Repair";
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
        EventScreen.enabled = true;
        EventBG.enabled = true;

        if (rt == "Hydration Chamber")
        {
            EventChoice = 1;
            EventScreen.Play("Intro");
            EventCall();
        }
        if (rt == "Labratory")
        {
            Button1.text = "Herp";
        }

        if (rt == "Cargo")
        {
            EventChoice = 9;
            EventScreen.Play("Intro");
            EventCall();
        }
    }
    public void BT2()
    {
        EventScreen.enabled = true;
        EventBG.enabled = true;

        if (rt == "Hydration Chamber")
        {
            EventChoice = 2;
            EventScreen.Play("Intro");
            EventBG.Play("EventIn");
            EventCall();
        }
        if (rt == "Labratory")
        {
            Button2.text = "Herp";
        }

        if (rt == "Cargo")
        {
            EventChoice = 10;
            EventScreen.Play("Intro");
            EventCall();
        }
    }

    public void BT3()
    {
        EventScreen.enabled = true;
        EventBG.enabled = true;

        if (rt == "Hydration Chamber")
        {
            EventChoice = 3;
            EventScreen.Play("Intro");
            EventCall();
        }
        if (rt == "Labratory")
        {
            Button3.text = "Herp";
        }

        if (rt == "Cargo")
        {
            EventChoice = 11;
            EventScreen.Play("Intro");
            EventCall();
        }
    }

    public void BT4()
    {
        EventScreen.enabled = true;
        EventBG.enabled = true;

        if (rt == "Hydration Chamber")
        {
            EventChoice = 4;
            EventScreen.Play("Intro");
            EventCall();
        }

        if (rt == "Labratory")
        {
            Button4.text = "Herp";
        }

        if (rt == "Cargo")
        {
            EventChoice = 12;
            EventScreen.Play("Intro");
            EventCall();
        }
    }

    public void EventCall()
    {
        if (EventChoice == 1)
        {
            EventTitle.text = "Heal all characters";
            EventBody.text = "For every character that is missing health, you will lose one medkit, but the character will be healed to full health. Do you wish to continue?";
            EventButton1.text = "Yes";
            EventButton2.text = "No";
        }

        if (EventChoice == 2)
        {
            EventTitle.text = "Download Memory";
            EventBody.text = "Do you wish to save progress and download your memory now? You may return to this memory in the future from the Main Menu.";
            EventButton1.text = "Yes";
            EventButton2.text = "No";
        }

        if (EventChoice == 3)
        {
            EventTitle.text = "Relax";
            EventBody.text = "Once per day, one of your crew members can regain energy in this chamber. Would you like to do this now?";
            EventButton1.text = "Yes";
            EventButton2.text = "No";
        }

        if (EventChoice == 4)
        {
            EventTitle.text = "Store Biomatter";
            EventBody.text = string.Format("You currently have {0} samples of biomatter, would you like to store them and convert them to Medkits?", placeholder);
            EventButton1.text = "Yes";
            EventButton2.text = "No";
        }

        if (EventChoice == 5)
        {
            EventTitle.text = "Relax";
            EventBody.text = "Once per day, one of your crew members can regain energy in this chamber. Would you like to do this now?";
            EventButton1.text = "Yes";
            EventButton2.text = "No";
        }

        if (EventChoice == 9)
        {
            EventTitle.text = "Exit the ship";
            EventBody.text = "Are you sure you wish to exit the ship and explore the surrounding area?";
            EventButton1.text = "Yes";
            EventButton2.text = "No";
        }
    }

    public void EventButtonOne()
    {
        if (EventChoice == 1)
        {
            EventScreen.Play("Outro");
            EventBG.Play("EventOut");
        }

        if (EventChoice == 2)
        {
            EventScreen.Play("Outro");
            EventBG.Play("EventOut");
        }

        if (EventChoice == 9)
        {
            Fade.enabled = true;
            EventScreen.Play("Outro");
            EventBG.Play("EventOut");
            StartCoroutine(ExitShip());
            Fade.Play("FadeOut");
        }
    }

    public void EventButtonTwo()
    {
        if (EventChoice == 1)
        {
            EventScreen.Play("Outro");
            EventBG.Play("EventOut");
        }

        if (EventChoice == 2)
        {
            EventScreen.Play("Outro");
            EventBG.Play("EventOut");
        }

        if (EventChoice == 9)
        {
            EventScreen.Play("Outro");
            EventBG.Play("EventOut");
        }
    }

    IEnumerator ExitShip()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Earth");
    }
}