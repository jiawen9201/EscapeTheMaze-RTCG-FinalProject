using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private static string[] scenesWithMusic = { "MainMenuScene", "TutorialScene", "BestScoreScene" };
    private AudioSource audioSource;

    void Start()
    {
        if (audioSource == null)
        {
            audioSource = FindObjectOfType<AudioManager>().GetComponent<AudioSource>();
        }
    }

    public void MainMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        PlayMusicIfNeeded("MainMenuScene");
        SceneManager.LoadScene("MainMenuScene");
        Debug.Log("Main Menu");
    }

    public void Play()
    {
        Cursor.lockState = CursorLockMode.None;
        StopMusicIfNeeded("PlayScene");
        SceneManager.LoadScene("PlayScene");
        Debug.Log("Play");
    }

    public void DisplayTutorial()
    {
        Cursor.lockState = CursorLockMode.None;
        PlayMusicIfNeeded("TutorialScene");
        SceneManager.LoadScene("TutorialScene");
        Debug.Log("Tutorial");
    }

    public void BestScore()
    {
        Cursor.lockState = CursorLockMode.None;
        PlayMusicIfNeeded("BestScoreScene");
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

    private void StopMusicIfNeeded(string sceneName)
    {
        if (audioSource != null && !System.Array.Exists(scenesWithMusic, scene => scene == sceneName))
        {
            audioSource.Stop();
        }
    }

    private void PlayMusicIfNeeded(string sceneName)
    {
        if (audioSource != null && System.Array.Exists(scenesWithMusic, scene => scene == sceneName))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
}
