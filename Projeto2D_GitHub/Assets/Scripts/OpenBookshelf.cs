using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenBookshelf : MonoBehaviour
{

    [SerializeField] private GameObject bookshelfMenu;
    [SerializeField] private GameObject player;
    private bool canInteract = false;

    private void Awake()
    {
        bookshelfMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canInteract == true)
        {
            bookshelfMenu.SetActive(true);
            player.GetComponent<PlayerControler>().enabled = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        canInteract = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canInteract = false;
    }
}
