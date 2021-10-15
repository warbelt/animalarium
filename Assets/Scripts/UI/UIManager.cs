using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    private void Start()
    {
        showScoreText(0, 0);
    }

    public void UpdateScore(int leftScore, int rightScore)
    {
        // TODO Score Effects

        showScoreText(leftScore, rightScore);
    }

    private void showScoreText(int leftScore, int rightScore)
    {
        scoreText.text = string.Format("{0} - {1}", leftScore, rightScore);
    }
}
