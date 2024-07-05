using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseOpenedObject : MonoBehaviour
{

    [SerializeField] private GameObject objectToClose;
    private PlayerControler playerControler;


    private void Awake()
    {
        playerControler = FindObjectOfType<PlayerControler>();
    }

    public void CloseObject()
    {
        playerControler.ToggleMovement();
        objectToClose.SetActive(false);
    }
}
