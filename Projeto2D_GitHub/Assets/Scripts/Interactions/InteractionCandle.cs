using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCandle : InteractionBase
{
    public override void Interact()
    {
        gameObject.GetComponent<DialogCandle>().StartDialog();
    }
}
