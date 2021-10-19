using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour, ICharacterInputProvider
{
    private float _moveH;
    private bool _jump;
    private bool _action;

    float ICharacterInputProvider.GetHorizontal()
    {
        return _moveH;
    }

    bool ICharacterInputProvider.GetJump()
    {
        return _jump;
    }

    bool ICharacterInputProvider.GetAction(){
        bool recordedValue = _action;
        // Clear action
        _action = false;

        return recordedValue;
    }

    private void OnMove(InputValue inputValue) {
        _moveH = inputValue.Get<float>();
    }

    private void OnJump(InputValue inputValue) {
        _jump = inputValue.Get<float>() > 0;
    }

    private void OnAction(InputValue inputValue) {
        _action = true;
    }
}
