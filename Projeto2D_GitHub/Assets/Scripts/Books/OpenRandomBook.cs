using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OpenRandomBook : MonoBehaviour
{
    //Random Text
    [SerializeField] private TextMeshProUGUI randomTextL;
    [SerializeField] private TextMeshProUGUI randomTextR;
    [SerializeField] private GameObject book;

    private float maxHeight = 0;
    private float maxWidth = 0;
    private double textSize = 0;

    RectTransform recTransform;

    private string randomString;

    //Page Number
    private int randomPageNumber;
    private int minPageNumber = 1;
    [SerializeField] private int maxPageNumber = 1000;
    [SerializeField] private TextMeshProUGUI pageNumberL;
    [SerializeField] private TextMeshProUGUI pageNumberR;

    private void Awake()
    {
       randomTextL.enabled = false;
       randomTextR.enabled = false;    
       book.SetActive(false);
    }

    private void Start()
    {
        recTransform = randomTextL.rectTransform;
        maxHeight = recTransform.rect.height;
        maxWidth = recTransform.rect.width;
        textSize = (maxHeight + maxWidth) * 1.25;
    }

    public void RandomBook()
    {
        CreateRandomTextL();
        CreateRandomTextR();
        CreateRandomPageNumber();
    }

    private void CreateRandomTextL()
    {
        randomTextL.enabled = true;
        book.SetActive(true);

        int string_Length = (int)textSize -1 ;
        randomString = "";
        string[] characters = new string[] {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p", 
            "q","r","s","t","u","v","w","x","y","z", ",", ".", " " };
        for (int i = 0; i < string_Length; i++)
        {
            randomString = randomString + characters[Random.Range(0, characters.Length)];
        }
        randomTextL.text = randomString;
    }

    private void CreateRandomTextR()
    {
        randomTextR.enabled = true;
        int string_Length = (int)textSize - 1;
        randomString = "";
        string[] characters = new string[] {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p",
            "q","r","s","t","u","v","w","x","y","z", ",", ".", " " };
        for (int i = 0; i < string_Length; i++)
        {
            randomString = randomString + characters[Random.Range(0, characters.Length)];
        }
        randomTextR.text = randomString;
    }

    private void CreateRandomPageNumber()
    {
        randomPageNumber = Random.Range(minPageNumber, maxPageNumber);
        pageNumberL.text = randomPageNumber.ToString();
        pageNumberR.text = (randomPageNumber+1).ToString();
    }

}
