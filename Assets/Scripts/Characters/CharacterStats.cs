using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    [SerializeField] private CharacterBottomPart _bottom;
    [SerializeField] private CharacterTopPart _top;

    public float HeadForce {
        get { return _top.headForce; }
    }

    public Vector2 HeadVelocity {
        get { return _top.headVelocity; }
    }


    public float RunSpeed {
        get { return _bottom.runSpeed; }
    }


    public float JumpForce {
        get { return _bottom.jumpForce; }
    }
}
