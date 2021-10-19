using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterInputProvider
{
    float GetHorizontal();
    bool GetJump();
    bool GetAction();
}
