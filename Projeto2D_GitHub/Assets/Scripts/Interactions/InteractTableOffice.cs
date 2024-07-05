using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTableOffice : InteractionBase
{
    public override void Interact()
    {
        gameObject.GetComponent<DialogOffice>().StartDialog();
    }
}
