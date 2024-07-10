using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BookManager : MonoBehaviour
{
    //a list for the books that player opened and unlock new dialog
    [field: SerializeField] public List<string> UnlockedBooks {  get; private set; }
    [field: SerializeField] public List<string> AllBooksToUnlock { get; private set; }

    public static BookManager Instance { get; private set; }

    public UnityEvent<string> OnBookRevealed {  get; private set; }

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

        UnlockedBooks = new List<string>(); 
    }

    public void Unlock(string id)
    {
        if (!UnlockedBooks.Contains(id))
        {
            UnlockedBooks.Add(id);
        }
    }

    public bool HasBook(string id)
    {
        return UnlockedBooks.Contains(id);
    }
    
    public void RevealBook(string id)
    {
        OnBookRevealed?.Invoke(id);
    }

}
