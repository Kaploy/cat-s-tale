using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI dialogueText;
	[SerializeField] GameObject dialogueBox;
	[SerializeField] float lettersPerSecond;
	public void ShowDialogue(Dialogue dialogue)
    {
		dialogueBox.SetActive(true);
		StartCoroutine(TypeDialogue(dialogue.Lines[0]));
    }

	public IEnumerator TypeDialogue(string line)
    {
		dialogueText.text = "";
		foreach (char letter in line.ToCharArray())
        {
			dialogueText.text += letter;
			yield return new WaitForSeconds(1f / lettersPerSecond);
        }
    }


}

