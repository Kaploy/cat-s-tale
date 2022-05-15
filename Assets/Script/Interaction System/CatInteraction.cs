using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatInteraction : Interactable
{
    public Animator transitionAnim;
    public float transitionTime = 2f;
    // Start is called before the first frame update
    public override string GetDescription()
    {
        return "Press [E] to go to next level.";
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
