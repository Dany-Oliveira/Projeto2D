using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using UnityEngine;

public class DialogBurnBookshelf : DialogBase
{
    public override void StartDialog()
    {
        ActivateDialogBox();
        dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("*you lit a fire in the bookshelf*"));
        dialogManager.Show(dialogTexts);
        QuestManager.Instance.StartFinalScene();
    }
}
