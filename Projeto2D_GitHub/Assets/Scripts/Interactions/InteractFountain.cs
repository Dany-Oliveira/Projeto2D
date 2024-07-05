using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractFountain : InteractionBase
{
    public bool canInteractFountain { get; private set; } = false;
    public override void Interact()
    {
        if (canInteractFountain)
        {
            gameObject.GetComponent<DialogFountain>().StartDialog();
        }
        else
        {
            gameObject.GetComponent<DialogCantInteract>().StartDialog();
        }

    }

    public void ToggleFountainInteraction()
    {
        if(canInteractFountain)
        {
            canInteractFountain = false;
        }
        else
        {
            canInteractFountain = true;
        }
    }
    
}
