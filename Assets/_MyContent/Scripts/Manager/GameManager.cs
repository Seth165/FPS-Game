using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    private GameState gState;
    public GameState State { get { return gState; } }

    private void Awake()
    {
        gState = GameState.Start;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
