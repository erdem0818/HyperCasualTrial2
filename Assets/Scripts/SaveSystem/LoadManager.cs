using UnityEngine;
using SlippyRoad;
using UnityEngine.SceneManagement;

public class LoadManager : BasedObject
{
    private FileManager fileManager;
    public PlayerView playerView {get; private set;}

    public override void BaseObjectStart()
    {
        fileManager = new FileManager();
        playerView = fileManager.GetPlayer();
        
        GameEvents.instance.StartLevel += LoadScene;  
    }
    public override void BaseObjectDestroy()
    {
        GameEvents.instance.StartLevel -= LoadScene;

    }
   
    void LoadScene()
    {
        SceneManager.LoadScene(playerView.Level);
    }

}
