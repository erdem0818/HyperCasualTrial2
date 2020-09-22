using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlippyRoad;
using DG.Tweening;

public class CameraShake : BasedObject
{
    [SerializeField] UIEvents uIEvents;

    public override void BaseObjectStart()
    {
        uIEvents.GameOver += ShakeTheCam;
    }
    public override void BaseObjectDestroy()
    {
        uIEvents.GameOver -= ShakeTheCam;
    }

    private void ShakeTheCam()
    {
        transform.DOShakePosition(1f,0.5f);
    }
}
