using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform destination;
    [SerializeField] private GameObject player;

    private GameObject currentDoor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            currentDoor = collision.gameObject;
            collision.GetComponent<InteractionSystem>().SetInteractable(this);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.gameObject == currentDoor)
            {
                currentDoor = null;
                collision.GetComponent<InteractionSystem>().SetInteractable(null);
            }
        }
    }

    public void Interact()
    {
        if (currentDoor != null)
        {
            player.transform.position = destination.position;
        }
    }

}
