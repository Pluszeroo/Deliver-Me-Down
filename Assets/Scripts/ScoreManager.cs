using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private int currentScore = 0;

    private void Start()
    {
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        scoreText.text = "Score " + currentScore;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Branches")) 
        {
            IncreaseScoreByOne();
        }
    }

    private void IncreaseScoreByOne()
    {
        currentScore++;
        UpdateScoreDisplay();
    }
}
