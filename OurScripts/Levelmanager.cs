using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelmanager : MonoBehaviour
{
    public Transform mainMenu, optionsMenu, soundsMenu, graphicsMenu, creditsMenu;

    public void LoadGame(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OptionsMenu(bool clicked)
    {
        if (clicked == true)
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }

    public void Sounds(bool clicked)
    {
        if (clicked == true)
        {
            soundsMenu.gameObject.SetActive(clicked);
            optionsMenu.gameObject.SetActive(false);
        }
        else
        {
            soundsMenu.gameObject.SetActive(clicked);
            optionsMenu.gameObject.SetActive(true);
        }
    }

    public void Graphics(bool clicked)
    {
        if (clicked == true)
        {
            graphicsMenu.gameObject.SetActive(clicked);
            optionsMenu.gameObject.SetActive(false);
        }
        else
        {
            graphicsMenu.gameObject.SetActive(clicked);
            optionsMenu.gameObject.SetActive(true);
        }
    }

    public void Credits(bool clicked)
    {
        if (clicked == true)
        {
            creditsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(!clicked);
        }
        else
        {
            creditsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(!clicked);
        }

        //creditsMenu.gameObject.SetActive(clicked);
        //mainMenu.gameObject.SetActive(!clicked);
    }

    public void BackToMenuFromCredits(bool clicked)
    {
        if (clicked == true)
        {
            mainMenu.gameObject.SetActive(clicked);
            creditsMenu.gameObject.SetActive(!clicked);
            
        }
        else
        {
            mainMenu.gameObject.SetActive(clicked);
            creditsMenu.gameObject.SetActive(!clicked);
           
        }

        //creditsMenu.gameObject.SetActive(clicked);
        //mainMenu.gameObject.SetActive(!clicked);
        //creditsMenu.gameObject.SetActive(true);
        //mainMenu.gameObject.SetActive(false);
    }

    public void Donate(bool clicked)
    {
        if (clicked == true)
        {
            Application.OpenURL("https://www.paypal.me/ProjectH69");
        }

    }

}

