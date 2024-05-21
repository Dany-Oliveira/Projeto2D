using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionSystem : MonoBehaviour
{

    private PlayerInput customInput;
    private bool canInteract = true; //To enable and disable Interaction System
    private IInteractable _interactableObject;

    private void Start()
    {
        customInput = InputManager.Instance.GetInputActions();
        customInput.Player.Interact.performed += Interact_performed;
    }

    private void OnDestroy()
    {
        customInput.Player.Interact.performed -= Interact_performed;
    }

    public void SetInteractable(IInteractable interactableObject)
    {
        _interactableObject = interactableObject;
    }

    private void Interact_performed(InputAction.CallbackContext obj)
    {
        if (canInteract && _interactableObject != null)
        {
            _interactableObject.Interact();
        }
    }

    public void EnableInteraction()
    {
        canInteract = true;
    }

    public void DisableInteraction() 
    {  
        canInteract = false;
    }
}
