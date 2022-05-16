using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingDialogue : MonoBehaviour
{
    public Dialogue starterDialogue;

    private void Start()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(starterDialogue);
    }
}
