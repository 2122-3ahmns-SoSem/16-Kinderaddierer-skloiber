using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

//Hilfsstruktur Aufzählung
public enum MyScenes
{
    WelcomeScene,
    SecondScene,
    EndScene
}

public class Manager : MonoBehaviour
{

    public TMP_InputField ipfKidsName;
    //public GameObject mabelBG;
    //public GameObject dipperBG;      DIe Symbole habe ich nicht hinbekommen
   //public GameObject pigBG;
    //public TMP_Text warning;

    private SoRuntimeData runtimeData;


    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");


    }
    




    }

    public void SwitchTheScene(string SecondScene)
    {
        SceneManager.LoadScene(SecondScene);


        runtimeData.nameKid = ipfKidsName.text;

       
    }
}