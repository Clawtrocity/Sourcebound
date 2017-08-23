using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crew : MonoBehaviour {

    public Text CrewName1;
    public Text CrewName2;
    public Text CrewName3;
    public Text CrewName4;
    public Slider CrewHealth1;
    public Slider CrewHealth2;
    public Slider CrewHealth3;
    public Slider CrewHealth4;
    public int chealth1;
    public int chealth2;
    public int chealth3;
    public int chealth4;
    public Slider CrewEnergy1;
    public Slider CrewEnergy2;
    public Slider CrewEnergy3;
    public Slider CrewEnergy4;
    public int cenergy1;
    public int cenergy2;
    public int cenergy3;
    public int cenergy4;
    public Image CrewOverlay1;
    public Image CrewOverlay2;
    public Image CrewOverlay3;
    public Image CrewOverlay4;
    public Color disabled;
    public Color injured;
    public Color dead;
    public Color normal;
    public Button Crew1;
    public Button Crew2;
    public Button Crew3;
    public Button Crew4;

    void Awake()
    {
        chealth1 = 1;
        chealth2 = 1;
        chealth3 = 1;
        chealth4 = 1;
        cenergy1 = 1;
        cenergy2 = 1;
        cenergy3 = 1;
        cenergy4 = 1;
        CrewName1.text = "?";
        CrewName2.text = "?";
        CrewName3.text = "?";
        CrewName4.text = "?";
    }

    void Start ()
    {
        CrewOverlay1.color = normal;
        CrewOverlay2.color = disabled;
        CrewOverlay3.color = disabled;
        CrewOverlay4.color = disabled;
    }
	
	void Update ()
    {
        CrewHealth1.value = chealth1;
        CrewHealth2.value = chealth2;
        CrewHealth3.value = chealth3;
        CrewHealth4.value = chealth4;
        CrewEnergy1.value = cenergy1;
        CrewEnergy2.value = cenergy2;
        CrewEnergy3.value = cenergy3;
        CrewEnergy4.value = cenergy4;
    }
}
