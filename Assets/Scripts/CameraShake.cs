using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlippyRoad;
using DG.Tweening;

public class CameraShake : BasedObject
{
    public override void BaseObjectStart()
    {
        GameEvents.instance.GameOver += ShakeTheCam;
    }
    public override void BaseObjectDestroy()
    {
        GameEvents.instance.GameOver -= ShakeTheCam;
    }

    private void ShakeTheCam()
    {
        transform.DOShakePosition(1f,0.5f);
    }
}
