using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private GameState _gameState;

    public void Awake()
    {
        Instance = this;
        
    }

    void Start()
    {
        _gameState = GameState.player1;
    }

    public void UpdateGameState (GameState gameState)
    {
        _gameState = gameState;

    }

    public GameState GetGameState => _gameState;
    
    public void SwitchPlayer()
    {
        if (_gameState == GameState.player1)
            _gameState = GameState.player2;
        else
            _gameState = GameState.player1;
    }

    public enum GameState
    {
        start,
        player1,
        player2,
        end
    }

    void update()
    {
        switch (_gameState)
        {
            case GameState.start:
                UpdateGameState(GameState.player1);
                break;
            case GameState.player1:
                break;
            case GameState.player2:
                break;
            case GameState.end:
                break;
        }
    }
}
