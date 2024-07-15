using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenBookshelf : InteractionBookshelfLetter
{
    [field: SerializeField] public string Id { get; private set; }
   
    private void Awake()
    {
        objectToOpen.SetActive(false);
    }

    protected override void InteractWithObject()
    {
        CheckObject();
    }

    private void CheckObject()
    {
        var questManager = QuestManager.Instance;

        if (questManager.CheckQuestState())
        {
            if(questManager.shelfId.Contains(Id))
            {
                questManager.StoreBookOnShelf(Id);
            }     
            else
            {
                gameObject.GetComponent<DialogCantInteract>().StartDialog();
            }

        }
        else if (questManager.HasCandle())
        {
            gameObject.GetComponent<DialogBurnBookshelf>().StartDialog();
        }
        else
        {
            playerControler.ToggleMovement();
            objectToOpen.SetActive(true);
        }
    }

   
}
