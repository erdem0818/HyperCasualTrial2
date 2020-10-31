using UnityEngine;
using SlippyRoad;
using DG.Tweening;

public class GameOver : BasedObject, ISlide
{

    public override void BaseObjectStart()
    {
        GameEvents.instance.GameOver += SlideTheObject;
    }
    public override void BaseObjectDestroy()
    {
        GameEvents.instance.GameOver -= SlideTheObject;
    }
    public void SlideTheObject()
    {
        var _endPos = new Vector2(0f,134f);
        transform.DOLocalMove(_endPos,0.5f).SetEase(Ease.OutCubic);
    }
}
