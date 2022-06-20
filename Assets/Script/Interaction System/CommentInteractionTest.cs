using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CommentInteractionTest : Interactable
{
    [SerializeField] string interactionName;
    [SerializeField] GameObject comment;
    [SerializeField] TextMeshProUGUI commentText;
    [SerializeField] string interactionComment;
    [SerializeField] float commentDuration;
    public override string GetDescription()
    {
        return interactionName;
    }
    
    public override void Interact() 
    {
        commentText.SetText(interactionComment);
        StartCoroutine(ShowComment());
    }

    IEnumerator ShowComment()
    {
        comment.SetActive(true);
        yield return new WaitForSeconds(commentDuration);
        comment.SetActive(false);
    }
}
