using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    private Vector2 direction;
    private Rigidbody2D rb;
    private PlayerInput customInput;
    private bool canMove = true;

    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private Animator animator;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        customInput = InputManager.Instance.GetInputActions();
        customInput.Player.Move.performed += Move_performed;
        customInput.Player.Move.canceled += Move_canceled;
    }

    private void OnDestroy()
    {
        customInput.Player.Move.performed -= Move_performed;
        customInput.Player.Move.canceled -= Move_canceled;
    }

    private void Move_canceled(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<Vector2>();
    }

    private void Move_performed(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<Vector2>();
        animator.SetFloat("X", direction.x);
        animator.SetBool("IsWalking", true);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);     

        if(direction.x == 0)
        {
            animator.SetBool("IsWalking", false);
        }
    }

    public void ToggleMovement()
    {
        if (canMove)
        {
            customInput.Player.Move.Disable();
            canMove = false;                  
        }
        else
        {
            customInput.Player.Move.Enable();
            canMove = true;            
        }
    }
}
