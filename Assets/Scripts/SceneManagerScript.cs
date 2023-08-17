using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    private string MenuSTR = "Menu";

    private string Level1 = "Game";
    private string Level2 = "GameWithoutWalls";
    private string Level3 = "Level3";

    public void GoLevel1()
    {
        SceneManager.LoadScene(Level1);
    }

    public void GoLevel2()
    {
        SceneManager.LoadScene(Level2);
    }

    public void GoLevel3()
    {
        SceneManager.LoadScene(Level3);
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(MenuSTR);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
