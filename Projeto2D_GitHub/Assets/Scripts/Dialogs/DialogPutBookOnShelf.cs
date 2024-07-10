using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using JetBrains.Annotations;
using UnityEngine;

public class DialogPutBookOnShelf : DialogBase
{
    public override void StartDialog()
    {
        ActivateDialogBox();

        dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("*you put the book on the shelf*", "Hermes"));

        if (QuestManager.Instance.CheckIfAllBooksHaveBeenDelivered())
        {
            dialogTexts.Add(new DialogData("*you've put all books in their place*"));
            dialogTexts.Add(new DialogData("It's done! I can leave now."));
            QuestManager.Instance.EndQuest();
            print("Quest State - " + QuestManager.Instance.CheckQuestState());
        }

        dialogManager.Show(dialogTexts);
    }


}
