using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlippyRoad;

public class TapToStart : BasedObject
{
    [SerializeField] UIEvents uIEvents;

    public override void BaseObjectStart()
    {
        uIEvents.StartLevel += TapToStartButton;
    }
    public override void BaseObjectDestroy()
    {
        uIEvents.StartLevel -= TapToStartButton;
    }

    private void TapToStartButton()
    {
        this.gameObject.SetActive(false);
    }
}
