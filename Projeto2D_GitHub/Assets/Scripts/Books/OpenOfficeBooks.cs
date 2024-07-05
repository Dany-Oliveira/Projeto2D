using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOfficeBooks : MonoBehaviour
{
    private PlayerControler playerControler;

    private void Start()
    {
        playerControler = FindObjectOfType<PlayerControler>();
    }

    public void OpenSelectedOfficeBook(GameObject officeBook)
    {
        playerControler.ToggleMovement();
        officeBook.SetActive(true);
    }
}
