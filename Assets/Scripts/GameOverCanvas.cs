using UnityEngine;
using UnityEngine.UI;

public class GameOverCanvas : MonoBehaviour
{
    public static GameOverCanvas Instance;
    [SerializeField] GameObject game_setup;
    [SerializeField] Text scoreText;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowGameOvaer()
    {
        scoreText.text = $"{Mathf.RoundToInt(ScoreController.score)}";

        game_setup.SetActive(false);
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
