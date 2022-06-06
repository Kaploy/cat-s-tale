using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameState { FreeRoam, Dialogue }
public class GameController : MonoBehaviour
{
    GameState state;

    // Start is called before the first frame update

    PlayerMovement playerControl;
    PlayerInteraction interactionControl;
    CameraControl cameraControl;
    void Awake()
    {
        playerControl = FindObjectOfType<PlayerMovement>();
        interactionControl = FindObjectOfType<PlayerInteraction>();
        cameraControl = FindObjectOfType<CameraControl>();
        
    }

    private void Start()
    {
        state = GameState.FreeRoam;
        DialogueManager.Instance.OnShowDialogue += () =>
        {
            state = GameState.Dialogue;
        };

        DialogueManager.Instance.OnCloseDialogue += () =>
        {
            state = GameState.FreeRoam;
        };

    }

    // Update is called once per frame
    void Update()
    {
        if(state == GameState.FreeRoam)
        {
            cameraControl.ControlUpdate();
            interactionControl.ControlUpdate();
            playerControl.ControlUpdate();
        }
        else
        {
            DialogueManager.Instance.ControlUpdate();
        }
        
    }
}
