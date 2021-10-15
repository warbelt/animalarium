using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAInput : MonoBehaviour, ICharacterInput
{
    [SerializeField] LayerMask ballMask;
    [SerializeField] LayerMask floorMask;
    Rigidbody2D ballRB;

    float moveH = 0;
    bool jump = false;

    private void Start()
    {
        FindBallRB()
;    }

    void Update()
    {
        if (ballRB != null)
        {
            Vector2 landingPoint;
            if (CalculateBallLinearLandingPoint(out landingPoint))
            {
                Debug.DrawLine(ballRB.transform.position, landingPoint);
                moveH = landingPoint.x > transform.position.x ? 1 : -1;
            }
            else moveH = 0;
        }
    }

    float ICharacterInput.getHorizontal()
    {
        return moveH;
    }

    public bool getJump()
    {
        return jump;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (((1 << collision.gameObject.layer) & ballMask.value) != 0)
        {

            jump = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (((1 << collision.gameObject.layer) & ballMask.value) != 0)
        {
            jump = false;
        }
    }

    public void SetBallRB(Rigidbody2D ballrb)
    {
        ballRB = ballrb;
    }

    /// <summary>
    /// Tries to find a RigidBody2D attached to the gameObject
    /// </summary>
    private void FindBallRB()
    {
        ballRB = GameObject.FindGameObjectWithTag("ball").GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Calculates whether the target is going to collide with the floor and writes collision point in the out param
    /// </summary>
    /// <param name="landingPoint">out - coordinates where the target gameobject is going to collide with floor</param>
    /// <returns>True if a collision is expected, false when trajectory is not towards collision</returns>
    private bool CalculateBallLinearLandingPoint(out Vector2 landingPoint)
    {
        RaycastHit2D hit = Physics2D.Raycast(ballRB.position, ballRB.velocity, 100, floorMask);

        landingPoint = hit.point;

        return hit.collider != null;
    }
}
