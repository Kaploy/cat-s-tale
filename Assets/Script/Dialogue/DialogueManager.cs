using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DialogueManager : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI dialogueText;
	[SerializeField] GameObject dialogueBox;
	[SerializeField] float lettersPerSecond;
	public GameObject playerController;
	bool dialogueOpen = false;
	int currentLine = 0;

	Dialogue dialogue;
	public static DialogueManager Instance { get; set; }

	public event Action OnShowDialogue;
	public event Action OnCloseDialogue;

	private void Awake()
	{
		Instance = this;
	}

    public void ShowDialogue(Dialogue dialogue)
    {
		OnShowDialogue?.Invoke();
		this.dialogue = dialogue;

		
		dialogueBox.SetActive(true);
		StartCoroutine(TypeDialogue(dialogue.Lines[0]));

    }

	public void ControlUpdate()
    {
		if (Input.GetKeyDown(KeyCode.E))
		{
			++currentLine;
			if (currentLine < dialogue.Lines.Count)
			{
				StartCoroutine(TypeDialogue(dialogue.Lines[currentLine]));
			}

			else
			{
				
				dialogueBox.SetActive(false);
				OnCloseDialogue?.Invoke();
				currentLine = 0;

			}
		}
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

