using System;
using UnityEngine;

public class GameEvents
{
    #region 
    public static GameEvents instance {get; private set;}= new GameEvents();
    private GameEvents() {}
    #endregion

    public event Action StartLevel;
    public void OnStartLevel()
    {
        if(StartLevel != null)
        {
            StartLevel();
        }
    }
    
    public event Action CompleteLevel;
    public void OnCompleteLevel()
    {
        if(CompleteLevel != null)
        {
            CompleteLevel();
        }
    }

    public event Action GameOver;
    public void OnGameOver()
    {
        if(GameOver != null)
        {
            GameOver();
        }
    }

    public event Action RestartLevel;
    public void OnRestartLevel()
    {
        if(RestartLevel != null)
        {
            RestartLevel();
        }
    }


}
