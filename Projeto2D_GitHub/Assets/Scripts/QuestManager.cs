using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Manages the current state of the game and with which object the player can interact

public class QuestManager : MonoBehaviour
{
    public static QuestManager Instance { get; private set; }
    private bool questActive = false;
    private bool finalQuestActive = false;
    private bool hasCandle = false;

    //this will store the the shelfs that the player needs to "store" the books from the office
    [field: SerializeField] public List<string> shelfId { get; private set; }

    //this will store a bool, to se if the player interacted with the shelf with the specific id
    private Dictionary<string, bool> booksDelivered;

    [SerializeField] private GameObject finalScreen;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        booksDelivered = new Dictionary<string, bool>();
    }

    private void Start()
    {
        for(int i = 0; i < shelfId.Count; i++)
        {
            booksDelivered.Add(shelfId[i], false);
        }
    }

    public void StartQuest()
    {
        questActive = true;
        GameManager.Instance.SetTextToQuest(shelfId);
    }

    public void EndQuest()
    {
        questActive = false;
        GameManager.Instance.SetTextToEndQuest();
    }

    public bool CheckQuestState()
    {
        return questActive;
    }

    public void StoreBookOnShelf(string shelf)
    {
        if (shelfId.Contains(shelf))
        {
            if (booksDelivered.ContainsKey(shelf))
            {
                booksDelivered[shelf] = true;
                gameObject.GetComponent<DialogPutBookOnShelf>().StartDialog();
            }
            else
            {
                print("The dictionary doesnt have that key");
            }
        }
        else
        {
            print("The list doesnt have that string");
        }
    }

    public bool CheckIfAllBooksHaveBeenDelivered()
    {
        foreach(bool value in booksDelivered.Values)
        {
            if (!value)
            {
                return false;
            }
        }    
        return true;
    }

    ///////////////////Final Quest////////////////////

    public void StartFinalQuest()
    {
        finalQuestActive = true;
    }

    public bool FinalQuestState()
    {
        return finalQuestActive;
    }

    public void PickUpCandle()
    {
        hasCandle = true;
    }

    public bool HasCandle()
    {
        return hasCandle;
    }

    public void StartFinalScene()
    {
        finalScreen.GetComponent<FinalScreen>().ActivateFinalScreen();      
    }

}
