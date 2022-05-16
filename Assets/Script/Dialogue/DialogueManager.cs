using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    //public TextMeshProUGUI nameText;
    public Text dialogueText;

    public Animator textAnimator;

    private Queue<string> sentences;

    void Awake()
    {
        sentences = new Queue<string>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        textAnimator.SetBool("IsOpen", true);
        //nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);

            DisplayNextSentence();
        }

    }

    
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        else
        {
            string sentence = sentences.Dequeue();
        }
    }

    void EndDialogue()
    {
        textAnimator.SetBool("IsOpen", false);
    }

}

