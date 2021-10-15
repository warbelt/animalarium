using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DebugUI : MonoBehaviour
{
    [Header("Game Objects")]
    [SerializeField] Rigidbody2D ballRB;
    [SerializeField] Vector3 ballStartPos;

    [Header("UI Elements")]
    [Space]
    [SerializeField] Text ballSpeedText;

    private void Awake()
    {
        ballStartPos = ballRB.transform.position;
    }

    private void Update()
    {
        ballSpeedText.text = "Ball speed: " + ballRB.velocity.magnitude.ToString("2f");

        if (Input.GetKeyDown("r")) {
            ballRB.transform.position = ballStartPos;
            ballRB.velocity = new Vector2(0,0);
        }
    }
}
