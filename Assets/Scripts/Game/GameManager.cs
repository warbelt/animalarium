using UnityEngine;
using Warbelt.ToolBelt;

public class GameManager : MonoBehaviour
{
    [SerializeField] ScoreTracker _trackerLeft;
    [SerializeField] ScoreTracker _trackerRight;
    [SerializeField] UIManager _uiManager;

    [SerializeField] ResetTool _resetTool;

    void Start()
    {
        _trackerLeft.OnScore += HandleScoreEvent;
        _trackerRight.OnScore += HandleScoreEvent;
    }

    private void HandleScoreEvent(int score)
    {
        _uiManager.UpdateScore(_trackerLeft.GetScore(), _trackerRight.GetScore());
        ResetPoint();
    }

    private void ResetPoint()
    {
        _resetTool.ResetAll();
    }
}
