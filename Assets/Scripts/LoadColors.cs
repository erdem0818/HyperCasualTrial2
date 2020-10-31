using UnityEngine;
using SlippyRoad;
using Dreamteck.Splines;

public class LoadColors : MonoBehaviour
{   
    //TÜM SAHNELERİ AUTO GENERATE YAP ÇIKTI ALMADAN ÖNCE
    [SerializeField] private ColorObject[] colorObjects;

   void Start()
   {
       LoadColorsData();
   }

   private void LoadColorsData()
    {
        int i = Random.Range(0,colorObjects.Length);

        BulletInteractions[] BulletArray = FindObjectsOfType<BulletInteractions>();

        for(int a=0; a<BulletArray.Length; a++)
        {
            BulletArray[a].GetComponent<Renderer>().material.color = colorObjects[i].EnemyColor;
        }

        Camera.main.backgroundColor = colorObjects[i].BackGroundColor;
        FindObjectOfType<PlayerInteractions>().GetComponent<Renderer>().material.color = colorObjects[i].PlayerColor;
        FindObjectOfType<SplineComputer>().GetComponent<Renderer>().material.color = colorObjects[i].SplineColor;

        
    }
}
