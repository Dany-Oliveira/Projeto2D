using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Manages the current state of the game and with which object the player can interact

public class QuestManager : MonoBehaviour
{
    public static QuestManager Instance { get; private set; }
    private bool questActive;

    //this will store the the shelfs that the player needs to "store" the books from the office
    [field: SerializeField] public List<string> shelfId { get; private set; }

    //this will store a bool, to se if the player interacted with the shelf with the specific id
    private Dictionary<string, bool> booksDelivered;

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
            print(shelfId[i]);
            booksDelivered.Add(shelfId[i], false);
        }
    }

    public void StartQuest()
    {
        questActive = true;
    }

    public void EndQuest()
    {
        questActive = false;
    }

    public bool CheckQuestState()
    {
        return questActive;
    }

    public void StoreBookOnShelf(string shelf)
    {
        print("id estante "+shelf);

        if (shelfId.Contains(shelf))
        {
            if (booksDelivered.ContainsKey(shelf))
            {
                booksDelivered[shelf] = true;
                gameObject.GetComponent<DialogPutBookOnShelf>().StartDialog();
            }
            else
            {
                print("The disctionary doesnt have that key");
            }
        }
        else
        {
            print("The list doesnt have that string");
        }
    }

}
