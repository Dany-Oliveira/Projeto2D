using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLetter : InteractionBookshelfLetter
{
    protected override void InteractWithObject()
    {
        objectToOpen.SetActive(true);
        playerControler.ToggleMovement();
    }

}
