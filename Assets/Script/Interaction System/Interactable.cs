using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // minigame is for custom types, for example connect wires to interact with doors
    public enum InteractionType
    {
        Click,
    }

    public InteractionType interactionType;

    public abstract string GetDescription();

    public abstract void Interact();

}
