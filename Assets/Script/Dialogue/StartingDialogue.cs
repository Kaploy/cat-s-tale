using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingDialogue : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueManager dialogueManager;
    private void Start()
    {
        dialogueManager.StartDialogue(dialogue);
    }
}
