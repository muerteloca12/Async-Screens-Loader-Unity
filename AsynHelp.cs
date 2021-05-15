﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AsynHelp : MonoBehaviour
{
    private string Escena = "Pantalla de carga"; // The name of your loading scene
  

    void Start()
    {
        

    }

    public void LoadScene(int move) // idea of use : button.onClick.AddListener(LoadScene(1));
    {
        PlayerPrefs.SetInt("Escena", move );
        PlayerPrefs.Save();
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        yield return null;


        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(Escena);



        yield return null;
    }



}
