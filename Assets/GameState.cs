using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
  public enum GameProgressStates
  {
    GameStart = 0,
    GameMain,
    GameResult
   }

    public GameProgressStates GameProgressState = GameProgressStates.GameStart;

    public void SetGameProgressState(GameProgressStates gameProgressState)
    {
        GameProgressState = gameProgressState;
    }

 }  