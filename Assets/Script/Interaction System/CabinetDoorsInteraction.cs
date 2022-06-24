using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetDoorsInteraction : Interactable
{
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
            return "Porta do arm�rio(Abrir)";
        }
        else
        {
            return "Porta do arm�rio(Fechar)";
        }

    }


    public override void Interact()
    {
        if (!doorOpen)
        {
            doorAnim.Play("cabinet_opening_anim");
            doorOpen = true;
        }
        else
        {

            doorAnim.Play("cabinet_closing_anim");
            doorOpen = false;
        }


    }
}
