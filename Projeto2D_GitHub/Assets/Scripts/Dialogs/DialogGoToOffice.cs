using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using UnityEngine;

public class DialogGoToOffice : DialogBase
{
    public override void StartDialog()
    {
        ActivateDialogBox();
        dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("I should go to the office. " +
            " *click to continue*", "Hermes"));
        dialogManager.Show(dialogTexts);
    }
}
