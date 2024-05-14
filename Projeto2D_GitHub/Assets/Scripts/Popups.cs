using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popups : MonoBehaviour
{

    [SerializeField] private GameObject popup;

    private void Awake()
    {
        popup.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            popup.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        popup.SetActive(false);        
    }

}
