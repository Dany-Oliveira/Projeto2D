using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using Unity.VisualScripting;
using UnityEngine;

public class DialogStartFinalQuest : DialogBase
{
    public override void StartDialog()
    {
        if (QuestManager.Instance.FinalQuestState())
        {
            ActivateDialogBox();
            dialogTexts = new List<DialogData>();
            dialogTexts.Add(new DialogData("I need to end this. I remeber there was a candle in the main room", "Hermes"));
            dialogManager.Show(dialogTexts);
            GameManager.Instance.GetCandle();
        }
        else
        {
            return;
        }
       
    }
}
