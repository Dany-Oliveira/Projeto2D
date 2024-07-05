using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using UnityEngine;

public class DialogOffice : DialogBase
{

    [SerializeField] private GameObject officeBook1;
    [SerializeField] private GameObject officeBook2;
    [SerializeField] private GameObject officeBook3;

    private bool book1PickedUp = false;
    private bool book2PickedUp = false;
    private bool book3PickedUp = false;

    public override void StartDialog()
    {
        ActivateDialogBox();
        InsertDialogInList();
        dialogManager.Show(dialogTexts);
    }

    private void InsertDialogInList()
    {
        dialogTexts = new List<DialogData>();

        //verify if all the books on the table have been read
        if (book1PickedUp && book2PickedUp && book3PickedUp) 
        {
            dialogTexts.Add(new DialogData("There are no more books on the table.", "Hermes"));
            dialogTexts.Add(new DialogData("I should return these books to their place."));
            return;
        }
     
        dialogTexts.Add(new DialogData("Humm, there are books on the table.", "Hermes"));

        var opcao = new DialogData("Which one should I read?");
        if (!book1PickedUp)
        {
            opcao.SelectList.Add("opcao 1", "The Tale of Prometheus");
        }
        if (!book2PickedUp)
        {
            opcao.SelectList.Add("opcao 2", "The Bird Fountain");
        }
        if (!book3PickedUp)
        {
            opcao.SelectList.Add("opcao 3", "Helen´s letter");
        }
      
        opcao.Callback = () => CheckPergunta();
        dialogTexts.Add(opcao);
    }

    private void CheckPergunta()
    {

        switch (dialogManager.Result)
        {
            case ("opcao 1"):
                gameObject.GetComponent<OpenOfficeBooks>().OpenSelectedOfficeBook(officeBook1);
                CheckBook();
                book1PickedUp = true;
                break;

            case ("opcao 2"):
                gameObject.GetComponent<OpenOfficeBooks>().OpenSelectedOfficeBook(officeBook2);
                CheckBook();
                book2PickedUp = true;
                break;

            case ("opcao 3"):
                gameObject.GetComponent<OpenOfficeBooks>().OpenSelectedOfficeBook(officeBook3);
                CheckBook();
                book3PickedUp = true;
                break;
        }

    }

    private void CheckBook()
    {
        dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("*you keep the book*"));

        if (book1PickedUp && book2PickedUp || book1PickedUp && book3PickedUp || book2PickedUp && book3PickedUp)
        {
            dialogTexts.Add(new DialogData("I should return these books to their place."));
            QuestManager.Instance.StartQuest();
        }
        dialogManager.Show(dialogTexts);      
    }

}
