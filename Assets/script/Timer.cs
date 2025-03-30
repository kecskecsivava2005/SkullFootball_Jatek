using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;  

public class GameTimer : MonoBehaviour
{
    public float gameTime = 60f; 
    private float currentTime;
    public TextMeshProUGUI timerText;  
    public GameObject gameOverPanel;   

    void Start()
    {
        gameOverPanel.SetActive(false); 
        Time.timeScale=1.0f;
    }

    void Update()
    {
        if (gameTime > 0)
        {
            gameTime -= Time.deltaTime;
            timerText.text = Mathf.Ceil(gameTime).ToString();

        }
        else
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameTime = 0;
        gameOverPanel.SetActive(true);  
        Time.timeScale = 0f;

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }
}
