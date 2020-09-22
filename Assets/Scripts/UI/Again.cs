using UnityEngine;
using UnityEngine.SceneManagement;
using SlippyRoad;
using DG.Tweening;

public class Again : BasedObject,ISlide
{
    [SerializeField] private UIEvents uIEvents;

    public override void BaseObjectStart()
    {
        uIEvents.GameOver += SlideTheObject;
        uIEvents.RestartLevel += RestartCurrentLevel;
    }

    public override void BaseObjectDestroy()
    {
        uIEvents.GameOver -= SlideTheObject;
        uIEvents.RestartLevel -= RestartCurrentLevel;
    }
    private void RestartCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SlideTheObject()
    {
        var _endPos = Vector3.zero;
        transform.DOLocalMove(_endPos,0.5f);
    }
}
