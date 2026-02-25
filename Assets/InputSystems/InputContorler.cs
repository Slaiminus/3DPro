using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class InputControler : MonoBehaviour
{

    [SerializeField] private PlayerMovement playerMovement;
    private Inputs _inputSystemActions;
    private bool isForward = false;
    private bool isBackward = false;
    private bool isRight = false;
    private bool isLeft = false;
    private void Awake()
    {
        _inputSystemActions = new Inputs();
    }


    private void Start()
    {
        _inputSystemActions.PlayerWalking.Enable();
    }

    private void FixedUpdate()
    {
        playerMovement.Walk(isForward, isBackward);
        playerMovement.Rotate(isLeft, isRight);
    }

    private void OnEnable()
    {
        _inputSystemActions.Enable();
        Bind();
    }

    private void OnDisable()
    {
        _inputSystemActions.Disable();
    }

    private void Bind()
    {
        _inputSystemActions.PlayerWalking.Jump.performed += OnJump;
        _inputSystemActions.PlayerWalking.Forward.started += Forward;
        _inputSystemActions.PlayerWalking.Forward.canceled += UnForward;
        _inputSystemActions.PlayerWalking.Backward.started += Backward;
        _inputSystemActions.PlayerWalking.Backward.canceled += UnBackward;
        _inputSystemActions.PlayerWalking.Left.started += Left;
        _inputSystemActions.PlayerWalking.Left.canceled += UnLeft;
        _inputSystemActions.PlayerWalking.Right.started += Right;
        _inputSystemActions.PlayerWalking.Right.canceled += UnRight;
    }

    private void OnJump(InputAction.CallbackContext obj)
    {
        Debug.Log("OnJump pressed");
        playerMovement.Jump();
    }
    private void Forward(InputAction.CallbackContext obj)
    {
        isForward = true;
    }

    private void UnForward(InputAction.CallbackContext obj)
    {
        isForward = false;
    }
    private void Backward(InputAction.CallbackContext obj)
    {
        isBackward = true;
    }

    private void UnBackward(InputAction.CallbackContext obj)
    {
        isBackward = false;
    }
    private void Left(InputAction.CallbackContext obj)
    {
        isLeft = true;
    }

    private void UnLeft(InputAction.CallbackContext obj)
    {
        isLeft = false;
    }
    private void Right(InputAction.CallbackContext obj)
    {
        isRight = true;
    }

    private void UnRight(InputAction.CallbackContext obj)
    {
        isRight = false;
    }
    private void Expose()
    {
       
    }

}