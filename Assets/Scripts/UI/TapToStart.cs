using UnityEngine;
using UnityEngine.EventSystems;
using SlippyRoad;

public class TapToStart : BasedObject , IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    { 
        GameEvents.instance.OnStartLevel();
    }
}
