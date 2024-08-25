using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
        StartCoroutine(WaitLevelReset1());
    }

    public void GoLevel2()
    {
        StartCoroutine(WaitLevelReset2());
    }

    public void GoLevel3()
    {
        StartCoroutine(WaitLevelReset3());
    }

    public void GoLevel4()
    {
        StartCoroutine(WaitLevelReset4());
    }

    public void GoLevel5()
    {
        StartCoroutine(WaitLevelReset5());
    }

    public void GoLevel6()
    {
        StartCoroutine(WaitLevelReset6());
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(MenuSTR);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    private IEnumerator WaitLevelReset2()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(Level2);
        Player.transform.position = new Vector2(-4, -4);
        Snake.MovementUp = false;
        Snake.MovementDown = false;
        Snake.MovementRight = false;
        Snake.MovementLeft = false;
    }

    private IEnumerator WaitLevelReset1()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(Level1);
        Player.transform.position = new Vector2(-4, -4);
        Snake.MovementUp = false;
        Snake.MovementDown = false;
        Snake.MovementRight = false;
        Snake.MovementLeft = false;
    }

    private IEnumerator WaitLevelReset3()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(Level3);
        Player.transform.position = new Vector2(-4, -4);
        Snake.MovementUp = false;
        Snake.MovementDown = false;
        Snake.MovementRight = false;
        Snake.MovementLeft = false;
    }

    private IEnumerator WaitLevelReset4()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(Level4);
        Player.transform.position = new Vector2(-4, -4);
        Snake.MovementUp = false;
        Snake.MovementDown = false;
        Snake.MovementRight = false;
        Snake.MovementLeft = false;
    }

    private IEnumerator WaitLevelReset5()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(Level5);
        Player.transform.position = new Vector2(-4, -4);
        Snake.MovementUp = false;
        Snake.MovementDown = false;
        Snake.MovementRight = false;
        Snake.MovementLeft = false;
    }

    private IEnumerator WaitLevelReset6()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(Level6);
        Player.transform.position = new Vector2(-4, -4);
        Snake.MovementUp = false;
        Snake.MovementDown = false;
        Snake.MovementRight = false;
        Snake.MovementLeft = false;
    }
}
