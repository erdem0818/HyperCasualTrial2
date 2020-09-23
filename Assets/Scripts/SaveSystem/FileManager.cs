using UnityEngine;
using SlippyRoad;
using System;

public class FileManager
{
    private void SetHandle(PlayerView playerView)
    {
        playerView.ValueChanged += OnValueChanged;
    }

    private void OnValueChanged(PlayerView p)
    {
        SavePlayer(p);
    }

    private void SavePlayer(PlayerView playerView)
    {
        PlayerData playerData = new PlayerData();
        playerData.highScore = playerView.HighScore;
        playerData.level = playerView.Level;

        PlayerPrefs.SetString("PlayerData",JsonUtility.ToJson(playerData));
    }

    public PlayerView GetPlayer()
    {
        PlayerView playerView = null;

        if(PlayerPrefs.HasKey("PlayerData"))
        {
            playerView = new PlayerView(JsonUtility.FromJson<PlayerData>(PlayerPrefs.GetString("PlayerData")));
            SetHandle(playerView);
            return playerView;
        }
        
        playerView = new PlayerView(new PlayerData() {highScore =0, level =1});
        SetHandle(playerView);
        return playerView;
    }
}
