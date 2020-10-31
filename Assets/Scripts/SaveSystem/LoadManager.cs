using UnityEngine;
using SlippyRoad;
using UnityEngine.SceneManagement;

public class LoadManager : BasedObject
{
    public PlayerView playerView {get; private set;}

    public override void BaseObjectStart()
    {
        playerView = FileManager.instance.GetPlayer();
        
        GameEvents.instance.StartLevel += LoadScene;  
    }
    public override void BaseObjectDestroy()
    {
        GameEvents.instance.StartLevel -= LoadScene;

    }
    void LoadScene()
    {
        SceneManager.LoadScene(playerView.Level+1);
    }

}
