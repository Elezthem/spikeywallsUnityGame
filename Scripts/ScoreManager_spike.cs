using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScoreManager_spike : MonoBehaviour
{
    public Text highScore;
    public Text currentScore;
    public int score;

    private void Start()
    {
        
        highScore.text = PlayerPrefs.GetInt("highScore_spike", 0).ToString();
    }

    public void addScore()
    {
        score += 1;
        currentScore.text = score.ToString();
        if(score > PlayerPrefs.GetInt("highScore_spike", 0))
        {
            PlayerPrefs.SetInt("highScore_spike", score);
            highScore.text = score.ToString();
        }
    }
}
