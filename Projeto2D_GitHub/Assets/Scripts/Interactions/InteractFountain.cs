using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractFountain : InteractionBase
{
    [SerializeField] private bool canInteractFountain = false;
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

    public void EnableFountainInteraction()
    {
        canInteractFountain = true;
    }

    public void DisableFountainInteraction()
    {
        canInteractFountain = false ;
    }
    
}
