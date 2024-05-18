using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class DialogFountain : MonoBehaviour
{
   
    [SerializeField] DialogManager dialogManager;
    [SerializeField] GameObject dialogManagerGameObject;

    private List<DialogData> dialogTexts;
    private bool canInteract = false;
 
    private void Awake()
    {
        dialogManagerGameObject.SetActive(false);     
    }

    private void Update()
    {
        if(canInteract && Input.GetKeyDown(KeyCode.E))
        {
           StartDialog();
        }
    }
     private void StartDialog()
    {
        ActivateDialogBox();
        InsertDialogInList();
        dialogManager.Show(dialogTexts);
    }

    private void ActivateDialogBox()
    {
       dialogManagerGameObject.SetActive(true);
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
    }

    private void CheckPergunta()
    {
        if(dialogManager.Result == "Pergunta 1")
        {
            dialogTexts = new List<DialogData>();
            dialogTexts.Add(new DialogData("Na Library of Babel!"));
            dialogManager.Show(dialogTexts);
        }
        else if(dialogManager.Result == "Pergunta 2")
        {
            dialogTexts = new List<DialogData>();
            dialogTexts.Add(new DialogData("O teu nome é Hermes"));
            dialogManager.Show(dialogTexts);
        }
        else
        {
            dialogTexts = new List<DialogData>();
            dialogTexts.Add(new DialogData("Eu sou uma fonte mágica"));
            dialogManager.Show(dialogTexts);
        }
      
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canInteract = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canInteract = false;
    }

}