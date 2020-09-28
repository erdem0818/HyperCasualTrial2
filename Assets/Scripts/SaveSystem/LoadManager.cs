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
        fileManager.GetPlayer();
        playerView = new PlayerView(new PlayerData() {level = 3 , highScore =4});
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
