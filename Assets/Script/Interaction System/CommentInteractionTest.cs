using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CommentInteractionTest : Interactable
{

    public Dialogue dialogue;
    public GameObject dialogueBox;
    public TextMeshProUGUI commentText;
    public string interactionComment;
    public float commentDuration;
    public override string GetDescription()
    {
        return "Examine";
    }
    
    public override void Interact() 
    {
        commentText.SetText(interactionComment);
        StartCoroutine(ShowComment());
    }

    IEnumerator ShowComment()
    {
        dialogueBox.SetActive(true);
        yield return new WaitForSeconds(commentDuration);
        dialogueBox.SetActive(false);
    }
}
