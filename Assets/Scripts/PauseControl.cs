using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class PauseControl : MonoBehaviour
{
    public static bool gameIsPaused;
    public TextMeshProUGUI text; 
    public GameObject statisticWindow;

    void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
        else if (Input.GetKeyDown("m"))
        {
            Cursor.lockState = CursorLockMode.None;
            statisticWindow.SetActive(false);
            SceneManager.LoadScene("MainMenuScene");
        }
    }

    void PauseGame()
    {
        if(gameIsPaused)
        {
            Time.timeScale = 0f;
            text.text = "Game Paused";
        }
        else
        {
            Time.timeScale = 1;
            text.text = "";
        }
    }
}
