using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueInteraction : Interactable
{
    [SerializeField] Dialogue dialogue;// Start is called before the first frame update
    [SerializeField] string interactionName;
    [SerializeField] Sprite inspectedObject;
    [SerializeField] Image objectImage;
    public bool hasImage = false;
    

    public override string GetDescription()
    {
        return interactionName;
    }


    public override void Interact()
    {
        if (hasImage)
        {
            objectImage.sprite = inspectedObject;
        }
        else
        {

        }
        
        DialogueManager.Instance.ShowDialogue(dialogue);

    }



}
