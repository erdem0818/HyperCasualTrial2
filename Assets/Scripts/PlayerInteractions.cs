using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlippyRoad;

public class PlayerInteractions : BasedObject
{
    public override void BaseObjectStart() => GameEvents.instance.GameOver += gameOver;
    public override void BaseObjectDestroy() => GameEvents.instance.GameOver -= gameOver;

    private void gameOver() => Debug.Log("yandın");
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Finish"))
        {
            GameEvents.instance.OnCompleteLevel();
        }
        else if(other.CompareTag("Bullet"))
        {
            GameEvents.instance.OnGameOver();          
        }
    }

}
