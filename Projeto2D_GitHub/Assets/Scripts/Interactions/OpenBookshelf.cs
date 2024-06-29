using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenBookshelf : MonoBehaviour, IInteractable
{

    [SerializeField] private GameObject bookshelfMenu;
    [SerializeField] private GameObject player;
  
    private PlayerInput customInput;

    private void Awake()
    {       
        bookshelfMenu.SetActive(false);
    }

    private void Start()
    {
        customInput = InputManager.Instance.GetInputActions();
    }

    public void Interact()
    {
        bookshelfMenu.SetActive(true);
        customInput.Player.Move.Disable(); 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<InteractionSystem>().SetInteractable(this);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<InteractionSystem>().SetInteractable(null);
        }
    }

}
