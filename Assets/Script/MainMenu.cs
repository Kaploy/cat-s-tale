using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transitionAnim;
    public int nextScene;
    public float transitionTime = 3.5f;

    public void PlayGame()
    {

        StartCoroutine(LoadScene());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("Finish");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(nextScene);
    }
}
