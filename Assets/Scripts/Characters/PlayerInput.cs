using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour, ICharacterInput
{
    [SerializeField] KeyCode moveLeftKey;
    [SerializeField] KeyCode moveRightKey;
    [SerializeField] KeyCode jumpKey;

    float moveH;
    bool jump;

    void Update()
    {
        var right = Input.GetKey(moveRightKey) ? 1 : 0;
        var left = Input.GetKey(moveLeftKey) ? 1 : 0;

        moveH = right - left;
        jump = Input.GetKey(jumpKey);
    }

    float ICharacterInput.getHorizontal()
    {
        return moveH;
    }

    public bool getJump()
    {
        return jump;
    }
}
