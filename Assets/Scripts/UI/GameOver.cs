using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlippyRoad;
using DG.Tweening;

public class GameOver : BasedObject, ISlide
{
    [SerializeField] UIEvents uIEvents;

    public override void BaseObjectStart()
    {
        uIEvents.GameOver += SlideTheObject;
    }
    public override void BaseObjectDestroy()
    {
        uIEvents.GameOver -= SlideTheObject;
    }
    public void SlideTheObject()
    {
        var _endPos = new Vector2(0f,62f);
        transform.DOLocalMove(_endPos,0.5f);
    }
}
