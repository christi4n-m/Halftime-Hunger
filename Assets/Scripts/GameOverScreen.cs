using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text scoreText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = score.ToString() + " SATISFACTION";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Main");
    }
}
