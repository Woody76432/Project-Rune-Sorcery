using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButtons : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject scoreboard;


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("MainGame"); 
    }
    public void ShowScoreboard()
    {
        scoreboard.SetActive(true);
        mainMenu.SetActive(false);
    }
}
