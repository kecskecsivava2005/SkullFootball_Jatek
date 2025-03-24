using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;  // Ha TextMeshPro-t használsz

public class GameTimer : MonoBehaviour
{
    public float gameTime = 60f; // Játékidõ másodpercben
    private float currentTime;

    public TextMeshProUGUI timerText;  // UI szöveg az idõ kijelzésére
    public GameObject gameOverPanel;   // Panel, ami megjelenik, ha lejár az idõ

    void Start()
    {

        currentTime = gameTime;
        gameOverPanel.SetActive(false); // Elrejtjük a Game Over panelt
        Time.timeScale=1.0f;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            timerText.text = Mathf.Ceil(currentTime).ToString(); // Kerekítve írja ki az idõt
        }
        else
        {
            EndGame();
        }
    }

    void EndGame()
    {
        currentTime = 0;
        gameOverPanel.SetActive(true);  // Megjeleníti a Game Over panelt
        Time.timeScale =0f;



    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Jelenet újratöltése
        



    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Fõmenü betöltése
    }
}
