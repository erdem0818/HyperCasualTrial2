using UnityEngine;
using SlippyRoad;

public class LoadManager : BasedObject
{
    [SerializeField] UIEvents uIEvents;

    private FileManager fileManager;
    public PlayerView playerView {get; private set;}


    public override void BaseObjectStart()
    {
        fileManager = new FileManager();
        playerView = fileManager.GetPlayer();
        
        uIEvents.CompleteLevel += ChangeLevelInt;     
    }
    public override void BaseObjectDestroy()
    {
        uIEvents.CompleteLevel -= ChangeLevelInt;
    }
   
    void ChangeLevelInt()
    {
        playerView.Level +=1;
        playerView.HighScore +=100;
    }


}
