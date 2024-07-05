using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using UnityEngine;

public class DialogCantInteract : DialogBase
{
    public override void StartDialog()
    {
        ActivateDialogBox();

        dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("I can't do that now.", "Hermes"));

        dialogManager.Show(dialogTexts);
    }
}
