using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BookManager : MonoBehaviour
{

    public List<string> UnlockedBooks {  get; private set; }

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
