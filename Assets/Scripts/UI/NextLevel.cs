using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using SlippyRoad;
using UnityEngine.SceneManagement;

public class NextLevel : BasedObject, ISlide, IPointerDownHandler
{
    private ChangeLevel changeLevel;

    public override void BaseObjectStart()
    {
        changeLevel = FindObjectOfType<ChangeLevel>();
        GameEvents.instance.CompleteLevel += SlideTheObject;
    }

    public override void BaseObjectDestroy()
    {
        GameEvents.instance.CompleteLevel -= SlideTheObject;
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
       SceneManager.LoadScene(changeLevel.playerView.Level+1);
    }

    public void SlideTheObject()
    {
        var _endPos = new Vector2(0f,-150f);
        transform.DOLocalMove(_endPos,0.5f).SetEase(Ease.OutCubic);
    }
}
