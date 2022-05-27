using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueInteractionTest : Interactable
{

    public Dialogue dialogue;
    public DialogueManager dialogueManager;
    public override string GetDescription()
    {
        return "Examine";
    }
    
    public override void Interact() 
    {
        dialogueManager.StartDialogue(dialogue);
    }
}
