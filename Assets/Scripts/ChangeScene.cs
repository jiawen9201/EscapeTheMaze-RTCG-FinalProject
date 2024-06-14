using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    void MainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
        Debug.Log("Main Menu");
    }
    void Play()
    {
        SceneManager.LoadScene("PlayScene");
        Debug.Log("Play");
    }
    void DisplayTutorial()
    {
        SceneManager.LoadScene("TutorialScene");
        Debug.Log("Tutorial");
    }
    void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
