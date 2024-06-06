using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenPredefineBook : MonoBehaviour
{
    [SerializeField] private GameObject predefinedBook;
  
    private void Awake()
    {
        predefinedBook.SetActive(false);
    }

    public void OpenPredefinedBook()
    {
        OpenBook();
    }
  
    private void OpenBook()
    {
        predefinedBook.SetActive(true);
    }

}
