using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public HighScores HighScores;

    public GameObject MainMenuImage;

    public Button NewGameButton;

    public GameObject[] Player;

    private float gameTime = 0f;
    public float GameTime { get { return gameTime; } }
    public enum GameState
    {
        Start,
        Playing,
        GameOver
    };

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Player") == null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        if (GameObject.FindWithTag("Enemy") == null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
