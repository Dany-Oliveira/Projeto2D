using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textUI;

    public static GameManager Instance { get; private set; }

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
    }

    private void Start()
    {
        SetStartingText();
    }

    private void SetStartingText()
    {
        textUI.text = "Explore the Office";
    }

    public void SetUIToBookCoordinates(string coordinates)
    {
        textUI.text = coordinates;
    }

    public void SetTextToQuest(List<string> books) 
    {
        string finalText = "";

        for (int i = 0; i < books.Count; i++)
        {
            if (i > 1)
            {
                finalText += "\n" + books[i];
            }
            else
            {
                finalText += books[i] + "  ";
            }                  
        }

        textUI.text = finalText;
    }

    public void SetTextToEndQuest()
    {
        textUI.text = "Exit the library";
    }

    public void SetTextTalkToFountain()
    {
        textUI.text = "Talk to the fountain";
    }
}
