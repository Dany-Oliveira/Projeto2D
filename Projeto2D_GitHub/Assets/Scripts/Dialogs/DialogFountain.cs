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
        var bookManager = BookManager.Instance;
      
        var Question = new DialogData("What should I ask?", "Hermes");
      

        //////////////////////////Question 1//////////////////////////////////
        
        if (!bookManager.HasBook("2-2-3-1-7"))
        {
            Question.SelectList.Add("Question 1", "Who is Hellen?");
        }
        else
        {
                Question.SelectList.Add("Question 1 2-2-3-1-7", "Who kidnapped Hellen?");
                Question.SelectList.Add("Question 2 2-2-3-1-7", "Did she survive?");  
        }

        //////////////////////////Question 2//////////////////////////////////
        if (!bookManager.HasBook("3-3-1-1-5"))
        {
            Question.SelectList.Add("Question 2", "Where is father?");
        }
        else
        {
            Question.SelectList.Add("Question 1 3-3-1-1-5", "What did he find out?");
            Question.SelectList.Add("Question 2 3-3-1-1-5", "Can I still save him?");
        }

        //////////////////////////Question 3//////////////////////////////////
        if (!bookManager.HasBook("1-2-3-3-2"))
        {
            Question.SelectList.Add("Question 3", "Where is the key to unlock the door?");
        }
        else
        {
            Question.SelectList.Add("Question 1 1-2-3-3-2", "How do I free them?");
            Question.SelectList.Add("Question 2 1-2-3-3-2", "Why does it have to be me?");
        }

        //////////////////////////Question 4//////////////////////////////////
        if (!bookManager.HasBook("2-2-3-1-6"))
        {
            Question.SelectList.Add("Question 4", "What happened to this place?");
        }
        else
        {
            Question.SelectList.Add("Question 1 2-2-3-1-6", "Who is the family?");
            Question.SelectList.Add("Question 2 2-2-3-1-6", "Did those people die?");
        }

        //////////////////////////Final Question//////////////////////////////////
        if (bookManager.HasBook("1-2-3-2-1") || bookManager.HasBook("1-2-2-3-2") ||
        bookManager.HasBook("3-1-3-5-6"))
        {
            Question.SelectList.Add("Final Question", "How can I stop them?");
            Question.SelectList.Remove("Question 1 2-2-3-1-7");
            Question.SelectList.Remove("Question 2 2-2-3-1-7");
        }


        Question.Callback = () => CheckPergunta();
        dialogTexts.Add(Question);

    }

    private void CheckPergunta()
    {
        var updateUI = GameManager.Instance;

        switch(dialogManager.Result)
        {
            case ("Question 1"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("2-2-3-1-7", "Fountain"));
                dialogManager.Show(dialogTexts);
                updateUI.SetUIToBookCoordinates("2-2-3-1-7");
                break;
         
            case ("Question 2"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("3-3-1-1-5", "Fountain"));
                dialogManager.Show(dialogTexts);
                updateUI.SetUIToBookCoordinates("3-3-1-1-5");
                break;

            case ("Question 3"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("1-2-3-3-2", "Fountain"));
                dialogManager.Show(dialogTexts);
                updateUI.SetUIToBookCoordinates("1-2-3-3-2");
                break;

            case ("Question 4"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("2-2-3-1-6", "Fountain"));
                dialogManager.Show(dialogTexts);
                updateUI.SetUIToBookCoordinates("2-2-3-1-6");
                break;

            //Question 2-2-3-1-7
            case ("Question 1 2-2-3-1-7"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("1-2-3-2-1", "Fountain"));
                dialogManager.Show(dialogTexts);
                updateUI.SetUIToBookCoordinates("1-2-3-2-1");
                break;

            case ("Question 2 2-2-3-1-7"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("1-2-2-3-2", "Fountain"));
                dialogManager.Show(dialogTexts);
                updateUI.SetUIToBookCoordinates("1-2-2-3-2");
                break;

            //Question 3-3-1-1-5
            case ("Question 1 3-3-1-1-5"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("3-1-3-5-6", "Fountain"));
                dialogManager.Show(dialogTexts);
                updateUI.SetUIToBookCoordinates("3-1-3-5-6");
                break;

            case ("Question 2 3-3-1-1-5"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("1-2-1-2-7", "Fountain"));
                dialogManager.Show(dialogTexts);
                updateUI.SetUIToBookCoordinates("1-2-1-2-7");
                break;

            //Question 1-2-3-3-2
            case ("Question 1 1-2-3-3-2"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("3-3-2-1-2", "Fountain"));
                dialogManager.Show(dialogTexts);
                updateUI.SetUIToBookCoordinates("3-3-2-1-2");
                break;

            case ("Question 2 1-2-3-3-2"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("3-1-1-5-7", "Fountain"));
                dialogManager.Show(dialogTexts);
                updateUI.SetUIToBookCoordinates("3-1-1-5-7");
                break;

            //Question 2-2-3-1-6
            case ("Question 1 2-2-3-1-6"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("2-2-3-1-3", "Fountain"));
                dialogManager.Show(dialogTexts);
                updateUI.SetUIToBookCoordinates("2-2-3-1-3");
                break;

            case ("Question 2 2-2-3-1-6"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("1-3-3-3-4", "Fountain"));
                dialogManager.Show(dialogTexts);
                updateUI.SetUIToBookCoordinates("1-3-3-3-4");
                break;

            //Final Question
            case ("Final Question"):
                dialogTexts = new List<DialogData>();
                dialogTexts.Add(new DialogData("2-1-1-2-9", "Fountain"));
                dialogManager.Show(dialogTexts);
                updateUI.SetUIToBookCoordinates("2-1-1-2-9");
                break;

        }

    }

 
}
