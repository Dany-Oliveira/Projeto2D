using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; } = null;
    private PlayerInput customInput;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            customInput = new PlayerInput();
        }
        else
        {
            Destroy(this);
        }
    }

    private void OnEnable()
    {
       customInput.Player.Enable();
    }

    private void OnDisable()
    {
       customInput.Player.Disable();
    }

    public PlayerInput GetInputActions()
    {
        return customInput;
    }
}
