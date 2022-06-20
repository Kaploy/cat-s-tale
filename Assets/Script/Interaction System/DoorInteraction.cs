using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : Interactable
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
            return "Porta(Abrir)";
        }
        else
        {
            return "Porta(Fechar)";
        }

    }


    public override void Interact()
    {
        if (!doorOpen)
        {
            doorAnim.Play("door_opening");
            doorOpen = true;
        }
        else
        {
            
            doorAnim.Play("door_closing");
            doorOpen = false;
        }
       

    }
}
