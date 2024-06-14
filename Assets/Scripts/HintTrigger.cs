using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintTrigger : MonoBehaviour
{
    public TextMeshProUGUI hintText;
    public TextMeshProUGUI trapOrClue;
    bool collide = false;
    public bool correctPath;
    PlayerMovement playerOriginalPosition; 
    GameObject player;

    void Start()
    {
        hintText.text = "";
        playerOriginalPosition = GameObject.Find("Player").GetComponent<PlayerMovement>();
        player = GameObject.Find("Player");
        trapOrClue.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with: " + other.gameObject.name);

        if (other.CompareTag("Player"))
        {
            collide = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        collide = false;
    }

    void checkInteraction()
    {
        if (Input.GetKeyDown("z"))
        {
            int n = Random.Range(0, 2); // random number 0 or 1 only
            Debug.Log(n.ToString());
            // 0 is clue, 1 is trap
            if (n == 0)
            {
                if (correctPath == true)
                {
                    StartCoroutine(displayTrapOrClue(3, "Clue: This is the CORRECT path"));
                }
                else
                {
                    StartCoroutine(displayTrapOrClue(3, "Clue: This is the WRONG path"));
                }
            }
            else
            {
                // transform the player to the starting point
                StartCoroutine(displayTrapOrClue(3, "Unfortunately, this is a TRAP. You will return to the starting position."));
                player.transform.position = playerOriginalPosition.playerOriginalPosition;
            }
        }
    }

    void Update()
    {
        if (collide == true)
        {
            hintText.text = "Click \"Z\" to view hint";
            checkInteraction();
        }
        else if (collide == false)
        {
            hintText.text = "";
        }
    }

    IEnumerator displayTrapOrClue(float duration, string text)
    {
        trapOrClue.text = text;
        yield return new WaitForSeconds(duration);
        trapOrClue.text = "";
    }
}
