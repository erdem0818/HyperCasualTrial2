using UnityEngine;
using UnityEngine.SceneManagement;
using SlippyRoad;
using DG.Tweening;
using UnityEngine.EventSystems;

public class Again : BasedObject,ISlide , IPointerDownHandler
{
    public override void BaseObjectStart()
    {
        GameEvents.instance.GameOver += SlideTheObject;
        GameEvents.instance.RestartLevel += RestartCurrentLevel;
    }

    public override void BaseObjectDestroy()
    {
        GameEvents.instance.GameOver -= SlideTheObject;
        GameEvents.instance.RestartLevel -= RestartCurrentLevel;
    }
    private void RestartCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SlideTheObject()
    {
        var _endPos = new Vector2(0f,-16f);
        transform.DOLocalMove(_endPos,0.5f).SetEase(Ease.OutCubic);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        GameEvents.instance.OnRestartLevel();
    }
}
