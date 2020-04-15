using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    //var
    public GameObject MainMenu, MenuOptions, MenuLevel;
    private bool booMainMenu = true, booMenuOptions = false, booMenuLevel = false;


    void Start()
    {
        MainMenu.SetActive(true);
        MenuOptions.SetActive(false);
        MenuLevel.SetActive(false);
    }

    //activer et desactiver menu principal
    public void EnableDisableMainMenu()
    {

        if(booMainMenu)
        {
            MainMenu.SetActive(false);
            booMainMenu = false;
        }
        else
        {
            MainMenu.SetActive(true);
            booMainMenu = true;
        }
    }

    //activer et desactiver menu d'options
    public void EnableDisableMenuOptions()
    {
        if(booMenuOptions)
        {
            MenuOptions.SetActive(false);
            booMenuOptions = false;
        }
        else
        {
            MenuOptions.SetActive(true);
            booMenuOptions = true;
        }
    }

    //activer et desactiver menu level
    public void EnableDisableMenuLevel()
    {
        if (booMenuLevel)
        {
            MenuLevel.SetActive(false);
            booMenuLevel = false;
        }
        else
        {
            MenuLevel.SetActive(true);
            booMenuLevel = true;
        }
    }

    //Load level
    public void LoadPartie1()
    {
        SceneManager.LoadScene("Level1");
    }

    //quitter le jeu
    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}

