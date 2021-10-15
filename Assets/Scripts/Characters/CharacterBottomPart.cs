using UnityEngine;

[CreateAssetMenu(fileName = "BottonPart", menuName = "Character Part/Bottom")]
public class CharacterBottomPart : ScriptableObject
{
    public float runSpeed = 40f;
    // Amount of force added when the player jumps.
    public float jumpForce = 400f;
}
