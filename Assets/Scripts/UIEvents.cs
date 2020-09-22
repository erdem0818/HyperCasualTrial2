using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEvents : MonoBehaviour
{
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

}
