using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseInGame : MonoBehaviour
{
    [SerializeField]
    GameObject PauseCanevas;
    private bool Paused = false;

    void Start()
    {
        PauseCanevas.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            Paused = !Paused;
        }

        if (Paused)
        {
            PauseCanevas.SetActive(true);
            Time.timeScale = 0;

        }

        if (!Paused)
        {
            PauseCanevas.SetActive(false);
            Time.timeScale = 1;

        }

    }

    public void Reprendre()
    {
        Paused = false;

    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
        Paused = false;

    }

    public void Quitter()
    {
        Application.Quit();
    }
}