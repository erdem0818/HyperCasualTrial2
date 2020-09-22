using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlippyRoad;

public class FinishTrigger : BasedObject
{   
    [SerializeField] UIEvents uIEvents;
    [SerializeField] GameObject _confetti;
    
    public override void BaseObjectStart()
    {
        uIEvents.CompleteLevel += Finished;
    }
    public override void BaseObjectDestroy()
    {
        uIEvents.CompleteLevel -= Finished;
    }
    private void Finished()
    {
        GameObject cloneConfetti = Instantiate(_confetti,transform.position,Quaternion.identity);
    }
}
