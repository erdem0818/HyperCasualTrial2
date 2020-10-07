using SlippyRoad;
using UnityEngine;

public class ChangeLevel : BasedObject
{
    private FileManager fileManager;
    public PlayerView playerView {get; private set;}

    public override void BaseObjectStart()
    {
        fileManager= new FileManager();
        playerView = fileManager.GetPlayer();

        GameEvents.instance.CompleteLevel += IncreaseLevel;
    }
    public override void BaseObjectDestroy()
    {
        GameEvents.instance.CompleteLevel -= IncreaseLevel;
    }

    private void IncreaseLevel()
    {
        playerView.Level +=1;
    }
}
