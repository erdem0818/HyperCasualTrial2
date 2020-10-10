using UnityEngine;
using Dreamteck.Splines;
using SlippyRoad;

public class PlayerController : BasedObject
{
   private ChangeLevel change;
   [SerializeField] private GameObject[] Levels;
   [SerializeField] private SplineComputer[] splines;

    
   private void OnEnable() => GameEvents.instance.CompleteLevel += LoadNext;
   private void OnDisable() => GameEvents.instance.CompleteLevel -= LoadNext;

   public override void BaseObjectStart()
   {
      change = FindObjectOfType<ChangeLevel>();
      Levels[change.playerView.Level].SetActive(true); // bi hata var
      SetPlayerPosition();
   }
   private void SetPlayerPosition()
   {
      SplinePoint[] splinePoints = splines[change.playerView.Level].GetPoints();
      transform.position = splinePoints[splinePoints.Length-1].position; 
   }

   private void LoadNext()
   {
      Levels[change.playerView.Level].SetActive(false);
      Levels[change.playerView.Level + 1].SetActive(true);
      transform.position = splines[1].GetPointPosition(0);
   }

}
