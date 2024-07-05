using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using Unity.VisualScripting;
using System;
using System.Runtime.CompilerServices;

public class DialogFountain : DialogBase
{
    public override void StartDialog()
    {
        ActivateDialogBox();
        InsertDialogInList();
        dialogManager.Show(dialogTexts);
    }

    private void InsertDialogInList()
    {
        dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("Ola eu sou Hermes", "Hermes"));
        dialogTexts.Add(new DialogData("Ola eu sou a fonte", "Fountain"));

        var Pergunta = new DialogData("'Tens alguma pergunta?'");
        Pergunta.SelectList.Add("Pergunta 1","Onde Estou?");
        Pergunta.SelectList.Add("Pergunta 2", "Qual é o meu nome?");
        Pergunta.SelectList.Add("Pergunta 3", "Quem és tu?");

        Pergunta.Callback = () => CheckPergunta();
        dialogTexts.Add(Pergunta);

        if (BookManager.Instance.HasBook("2-3-3-1-7"))
        {
            Pergunta.SelectList.Add("Pergunta 4", "encontrei o livro ");
        }
    }

    private void CheckPergunta()
    {

        switch(dialogManager.Result)
        {
            case ("Pergunta 1"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("Na Library of Babel!"));
                dialogManager.Show(dialogTexts);
                break;

            case ("Pergunta 2"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("O teu nome é Hermes"));
                dialogManager.Show(dialogTexts);
                break;

            case ("Pergunta 3"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("Eu sou uma fonte mágica"));
                dialogManager.Show(dialogTexts);
                break;

            case ("Pergunta 4"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("encontraste o livro"));
                dialogManager.Show(dialogTexts);
                break;
        }
       
    }

 
}
