﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuScriptStart : MonoBehaviour
{
    [SerializeField]
    Button[] menuButtons;

    public void switchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void doExitScene()

    {
        Application.Quit();
    }
}