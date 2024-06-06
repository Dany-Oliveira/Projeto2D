using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBookshelf : MonoBehaviour
{

    [SerializeField] private GameObject bookshelfToClose;
    private PlayerInput customInput;

    private void Start()
    {
        customInput = InputManager.Instance.GetInputActions();
    }

    public void CloseOpenedBookshelf()
    {
        customInput.Enable();
        bookshelfToClose.SetActive(false);
    }
}
