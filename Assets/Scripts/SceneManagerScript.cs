using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    private string MenuSTR = "Menu";

    private string Level1 = "Game";
    private string Level2 = "GameWithoutWalls";
    private string Level3 = "Level3";
    private string Level4 = "Level4";
    private string Level5 = "Level5";
    private string Level6 = "Level6";

    [SerializeField] private GameObject Player;

    public void GoLevel1()
    {
        SceneManager.LoadScene(Level1);
        Player.transform.position = new Vector2(-4, -4);
    }

    public void GoLevel2()
    {
        SceneManager.LoadScene(Level2);
        Player.transform.position = new Vector2(-4, -4);
    }

    public void GoLevel3()
    {
        SceneManager.LoadScene(Level3);
        Player.transform.position = new Vector2(-4, -4);
    }

    public void GoLevel4()
    {
        SceneManager.LoadScene(Level4);
        Player.transform.position = new Vector2(-4, -4);
    }

    public void GoLevel5()
    {
        SceneManager.LoadScene(Level5);
        Player.transform.position = new Vector2(-4, -4);
    }

    public void GoLevel6()
    {
        SceneManager.LoadScene(Level6);
        Player.transform.position = new Vector2(-4, -4);
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
