using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlippyRoad;

public class PlayerInteractions : BasedObject
{
    [SerializeField] UIEvents uIEvents;
    
    public override void BaseObjectStart()
    {   
        uIEvents.GameOver += gameOver;
    }
    public override void BaseObjectDestroy()
    {
        uIEvents.GameOver -= gameOver;
    }
    private void gameOver()
    {
        Debug.Log("yandın");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Finish"))
        {
            uIEvents.OnCompleteLevel();
        }
        else if(other.CompareTag("Bullet"))
        {
            uIEvents.OnGameOver();          
        }
    }

}
