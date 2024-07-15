using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using UnityEngine;

public class DialogCandle : DialogBase
{
    public override void StartDialog()
    {
        ActivateDialogBox();

        dialogTexts = new List<DialogData>();

        if (!QuestManager.Instance.FinalQuestState())
        {
            dialogTexts.Add(new DialogData("It's just a candle", "Hermes"));            
        }
        else
        {
            dialogTexts.Add(new DialogData("There it is, the candle.", "Hermes"));
            dialogTexts.Add(new DialogData("*you picked up the candle*"));
            QuestManager.Instance.PickUpCandle();
            GameManager.Instance.SetTextToBurnBookshelf();
        }

        dialogManager.Show(dialogTexts);
    }

}
