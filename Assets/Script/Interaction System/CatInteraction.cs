using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatInteraction : Interactable
{
    public Animator transitionAnim;
    float transitionTime = 2f;
    [SerializeField] string textDescription;
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
        transitionAnim.SetTrigger("Finish");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(nextScene);
    }
}
