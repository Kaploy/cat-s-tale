using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInteraction : Interactable
{
    [SerializeField] Dialogue dialogue;// Start is called before the first frame update
    [SerializeField] string interactionName;
    

    public override string GetDescription()
    {
        return interactionName;
    }


    public override void Interact()
    {
        DialogueManager.Instance.ShowDialogue(dialogue);

    }



}
