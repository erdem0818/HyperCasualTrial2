using UnityEngine;
using SlippyRoad;

public class FinishTrigger : BasedObject
{   
    
    [SerializeField] GameObject[] _confetti;

    public override void BaseObjectStart() => GameEvents.instance.CompleteLevel += Finished;
    public override void BaseObjectDestroy() => GameEvents.instance.CompleteLevel -= Finished;
    
    private void Finished()
    {
        foreach(GameObject e in _confetti)
        {
           e.SetActive(true);
        }
        
    }
}
