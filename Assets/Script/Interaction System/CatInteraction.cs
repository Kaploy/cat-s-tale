using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatInteraction : Interactable
{
    public Animator transitionAnim;
    [SerializeField] float transitionTime;
    [SerializeField] string textDescription;
    [SerializeField] string finishLevelTrigger;
    // Start is called before the first frame update
    public override string GetDescription()
    {
        return textDescription;
    }

    public override void Interact()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int nextScene)
    {
        transitionAnim.SetTrigger(finishLevelTrigger);
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(nextScene);
    }
}
