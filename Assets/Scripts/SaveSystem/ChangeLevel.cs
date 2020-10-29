using SlippyRoad;
using UnityEngine;

public class ChangeLevel : BasedObject
{
    public PlayerView playerView {get; private set;}

    public override void BaseObjectAwake()
    {
        playerView = FileManager.instance.GetPlayer();

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
