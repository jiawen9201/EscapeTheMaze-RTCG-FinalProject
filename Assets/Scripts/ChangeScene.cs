using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public void MainMenu()
    {
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
        SceneManager.LoadScene("TutorialScene");
        Debug.Log("Tutorial");
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
