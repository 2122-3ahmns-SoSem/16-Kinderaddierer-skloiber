using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

//Hilfsstruktur
public enum MyScene
{
    WelcomeScene,
    MainScene,
    MainScene2,
    MainScene3,
    EndScene
}



public class Manager : MonoBehaviour
{

    public TMP_Text displayKidsName;

    public InputField ipfKidsName;
    // public TMP_InputField

    public SoRuntimeData runtimeData;


    public void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRunTimeData");

        if (SceneManager.GetActiveScene().buildIndex == (int)MyScene.MainScene)
        {
            Debug.Log("in Scene Round1");
            Debug.Log(runtimeData.name + "rd");
            displayKidsName.text = runtimeData.nameKid;
        }
        
    }

    public void SwitchTheScene(int x)  //Aufruf in Inspector OnClick bei Button, generisch über Parameter
    {
        Debug.Log("BIN Pressed, get kidsname" + ipfKidsName.text);
        runtimeData.nameKid = ipfKidsName.text;

        SceneManager.LoadScene(x);


        if (SceneManager.GetActiveScene().buildIndex == (int)MyScene.MainScene)
        {
            displayKidsName.text = runtimeData.nameKid;
        }

    }

    public void SwitchTheScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


    public void SwitchToEnd()  //Jede Szene wird einzeln aufgerufen, muss dann auch 
    //für jede Szene eine Methode schreiben
    {
        SceneManager.LoadScene((int)MyScene.EndScene);
    }
   


    
   



}
