using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlippyRoad;

public class UIButtons : BasedObject
{
    [SerializeField] UIEvents uIEvents;

    public void ClickRestartButton()
    {
        uIEvents.OnRestartLevel();
    }   

    public void ClickStartButton()
    {
        uIEvents.OnStartLevel();
    }
}
