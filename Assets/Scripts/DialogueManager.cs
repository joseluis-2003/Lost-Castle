using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private bool isEntered;

    public GameObject dialogueBox; 
    public Text dialogueText; 

    [TextArea(1, 4)] 
    public string dialogue;
    


    private void Start()
    {
        //dialogueText.text = dialogueLines[currentLine];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = false;
            dialogueBox.SetActive(false);
        }
    }

    private void Update()
    {
        if (isEntered && Input.GetKeyDown(KeyCode.Space))
        {
            if (dialogueBox.activeInHierarchy)
            {
                dialogueBox.SetActive(false);
            }
            else
            {
                dialogueBox.SetActive(true);
                dialogueText.text = dialogue;
            }
        }


    }
}
