using UnityEngine;

[CreateAssetMenu(fileName = "TopPart", menuName = "Character Part/Top")]
public class CharacterTopPart : ScriptableObject
{
    public float headForce = 200;
    public Vector2 headVelocity = new Vector2(10, 4);

}
