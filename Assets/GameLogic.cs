using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameLogic : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject panel;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd ;
        scoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
    public void Exit_Clicked()
    {
        Application.Quit();
    }
   
    public void disable_confirmation()
    {
        Time.timeScale = 1;
        panel.SetActive(false);

    }
    public void enable_confirmation()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           enable_confirmation();
        }
    }

}
