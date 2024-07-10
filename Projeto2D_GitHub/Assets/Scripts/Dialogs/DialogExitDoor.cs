using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class DialogExitDoor : DialogBase
{
    [SerializeField] private UnityEvent OnExitDoorDialogEnd;
    public override void StartDialog()
    {
        ActivateDialogBox();

        dialogTexts = new List<DialogData>();

        if (!QuestManager.Instance.CheckIfAllBooksHaveBeenDelivered())
        {
            dialogTexts.Add(new DialogData("I have to go to the office first", "Hermes"));
        }
        else
        {
            dialogTexts.Add(new DialogData("Humm...Strange...The door is closed...", "Hermes"));
            dialogTexts.Add(new DialogData("I should go ask the fountain what to do."));
            OnExitDoorDialogEnd.Invoke();
        }
     
        dialogManager.Show(dialogTexts);
    }

}
