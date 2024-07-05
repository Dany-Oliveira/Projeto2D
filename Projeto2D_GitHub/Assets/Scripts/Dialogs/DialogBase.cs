using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using UnityEngine;

public abstract class DialogBase : MonoBehaviour
{

    [SerializeField] protected DialogManager dialogManager;
    [SerializeField] protected GameObject dialogManagerGameObject;

    protected List<DialogData> dialogTexts;
    protected PlayerInput customInput;

    protected void Awake()
    {
        dialogManagerGameObject.SetActive(false);
    }

    protected void Start()
    {
        customInput = InputManager.Instance.GetInputActions();
    }

    public abstract void StartDialog();

    protected void ActivateDialogBox()
    {
        dialogManagerGameObject.SetActive(true);
        customInput.Player.Interact.Disable();
        customInput.Player.Move.Disable();
    }
   
}