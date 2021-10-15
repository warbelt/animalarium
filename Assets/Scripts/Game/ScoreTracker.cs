using System;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    // Left field scores a point for right player
    [SerializeField] private GroundScoringZone _ground;
    private int _score;
    public event Action<int> OnScore;

    private void Awake()
    {
        _score = 0 ;
    }

    private void Start()
    {
        _ground.OnBallTouchGround += _addScore;
    }

    private void _addScore()
    {
        _score += 1;
        OnScore.Invoke(_score);
    }

    public int GetScore()
    {
        return _score;
    }
}
