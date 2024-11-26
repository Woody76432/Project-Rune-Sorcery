using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScoreboardButtons : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject scoreboard;

    public void BackButton()
    {
        scoreboard.SetActive(false);
        mainMenu.SetActive(true);
    }
}
