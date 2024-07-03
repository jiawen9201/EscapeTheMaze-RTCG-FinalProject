using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class WinTrigger : MonoBehaviour
{
    TimeCountdown time;

    void Start()
    {
        time = GameObject.Find("GameManager").GetComponent<TimeCountdown>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with: " + other.gameObject.name);

        if (other.CompareTag("Player"))
        {
            if (time.currentTime > 0)
            {
                PlayerPrefs.SetInt("timetaken", (int)time.duration - (int)time.currentTime);
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("WinScene");
            }
        }
    }
}
