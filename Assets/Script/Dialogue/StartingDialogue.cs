using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingDialogue : MonoBehaviour
{
    public Dialogue dialogue;
  
    private void Start()
    {
        StartCoroutine(StarterDialogue());
    }

    IEnumerator StarterDialogue()
    {
        yield return new WaitForSeconds(2f);
        DialogueManager.Instance.ShowDialogue(dialogue);
    }
}
