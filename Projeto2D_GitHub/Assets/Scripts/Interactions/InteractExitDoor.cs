using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractExitDoor : InteractionBase
{ 
    public override void Interact()
    {
        gameObject.GetComponent<DialogExitDoor>().StartDialog();
    }
}
