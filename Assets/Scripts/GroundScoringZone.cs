using UnityEngine;
using System;
using Warbelt.ToolBelt;

[RequireComponent(typeof(Rigidbody2D))]
public class GroundScoringZone : MonoBehaviour
{
    [SerializeField] private LayerMask _whatTriggersGround;
    public event Action OnBallTouchGround;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (LogicToolBelt.IsLayerInLayerMask(collision.gameObject.layer, _whatTriggersGround)) {
            OnBallTouchGround.Invoke();
        }
    }
}
