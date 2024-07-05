using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using UnityEngine;

public class DialogPutBookOnShelf : DialogBase
{
    public override void StartDialog()
    {
        ActivateDialogBox();

        dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("*you put the book on the shelf*", "Hermes"));

        dialogManager.Show(dialogTexts);
    }
}
