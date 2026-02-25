using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public void StartGame()
    {
        gameManager.StartGame();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void CountineGame()
    {
        gameManager.ResumeGame();
    }
    public void MainMenu()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
