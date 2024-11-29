using UnityEngine.UI;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public static float score;
    private Text scoreText;

    private void Awake()
    {
        score = 0;
        scoreText = GetComponent<Text>();
    }

    private void Update()
    {
        score += 3 * Time.deltaTime;
        scoreText.text = $"{Mathf.RoundToInt(score)}";
    }
}
