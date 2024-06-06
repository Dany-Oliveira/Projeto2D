using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class BookClickControler : MonoBehaviour
{

    private Camera _mainCamera;

    private OpenPredefineBook _openPredefineBook;
    private LayerMask _layerMask;

    private void Awake()
    {
        _mainCamera = Camera.main;
        _openPredefineBook = FindObjectOfType<OpenPredefineBook>();   
        _layerMask = LayerMask.GetMask("Books");
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()), _layerMask);

        if (!rayHit.collider) return;


        if (rayHit.collider.CompareTag("PredefinedBook1"))
        {
            _openPredefineBook.OpenPredefinedBook();
            return;
        }
    }

    

}
