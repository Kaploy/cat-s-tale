using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingDialogue : MonoBehaviour
{
    public Dialogue dialogue;

    private void Start()
    {
        FindObjectOfType<DialogueManager>().StartDialogue();
    }
}
