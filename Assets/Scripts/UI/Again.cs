using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlippyRoad;
using DG.Tweening;

public class Again : BasedObject
{
    [SerializeField] private UIEvents uIEvents;

    public override void BaseObjectStart()
    {
        uIEvents.GameOver += SlideTheButton;
    }

    public override void BaseObjectDestroy()
    {
        uIEvents.GameOver -= SlideTheButton;
    }

    private void SlideTheButton()
    {
        var _endPos = Vector3.zero;
        transform.DOLocalMove(_endPos,0.5f);
    }
}
