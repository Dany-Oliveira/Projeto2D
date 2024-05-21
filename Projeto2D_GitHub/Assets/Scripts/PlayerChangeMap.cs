using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerChangeMap : MonoBehaviour
{
   /* private GameObject currentDoor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
            currentDoor = collision.gameObject;
            collision.GetComponent<InteractionSystem>().SetInteractable();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
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
            print("Estou aqui");
            transform.position = currentDoor.GetComponent<Doors>().GetDestination().position;
        }
    }*/
}
