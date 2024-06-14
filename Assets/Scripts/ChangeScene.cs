using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public void MainMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("MainMenuScene");
        Debug.Log("Main Menu");
    }
    public void Play()
    {
        SceneManager.LoadScene("PlayScene");
        Debug.Log("Play");
    }
    public void DisplayTutorial()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("TutorialScene");
        Debug.Log("Tutorial");
    }
    public void BestScore()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("BestScoreScene");
        Debug.Log("Best Score");
    }
    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
        Debug.Log("Quit");
    }
}
