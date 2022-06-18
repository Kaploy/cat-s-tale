using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special_Bathroom_DoorInteraction : Interactable
{
    // Start is called before the first frame update
    public Animator doorAnim;
    public bool doorOpen = false;

    private void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }
    public override string GetDescription()
    {
        if (!doorOpen)
        {
            return "Door(Open)";
        }
        else
        {
            return "Door(Close)";
        }

    }


    public override void Interact()
    {
        if (!doorOpen)
        {
            doorAnim.Play("door_opening_firstlevel");
            doorOpen = true;
        }
        else
        {

            doorAnim.Play("door_closing");
            doorOpen = false;
        }


    }
}
