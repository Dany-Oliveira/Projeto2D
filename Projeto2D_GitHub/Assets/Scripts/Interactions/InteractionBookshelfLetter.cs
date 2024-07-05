using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractionBookshelfLetter : InteractionBase
{
    [SerializeField] protected GameObject objectToOpen;

    protected PlayerControler playerControler;

    private void Start()
    {
        playerControler = FindObjectOfType<PlayerControler>();
    }

    protected abstract void InteractWithObject();

    public override void Interact()
    {
        InteractWithObject();
    }
   
}
