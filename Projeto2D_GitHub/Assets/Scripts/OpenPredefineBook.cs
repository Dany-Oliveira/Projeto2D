using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenPredefineBook : MonoBehaviour
{
    [SerializeField] private GameObject predefinedBook;
   
    private Camera _mainCamera;

    private void Awake()
    {
        _mainCamera = Camera.main;
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
