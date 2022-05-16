using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInteractionTest : Interactable
{
    // Start is called before the first frame update
    public Dialogue dialogue;
    public override string GetDescription()
    {
        return "Press [E]";
    }

    public override void Interact()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
