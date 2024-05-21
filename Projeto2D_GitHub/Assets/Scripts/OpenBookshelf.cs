using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenBookshelf : MonoBehaviour, IInteractable
{

    [SerializeField] private GameObject bookshelfMenu;
    [SerializeField] private GameObject player;
    private PlayerControler playerControler;

    private PlayerInput customInput;

    private void Awake()
    {
        playerControler = FindObjectOfType<PlayerControler>();
        bookshelfMenu.SetActive(false);
    }
   
    public void Interact()
    {
        bookshelfMenu.SetActive(true);
        player.GetComponent<PlayerControler>().enabled = false;
    
        //customInput.Player.Move.Disable(); Nao funciona
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
