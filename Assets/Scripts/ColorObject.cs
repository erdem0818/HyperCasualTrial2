using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName= "Colors", fileName="ColorObject")]
public class ColorObject : ScriptableObject
{
    public Color BackGroundColor;
    public Color PlayerColor;
    public Color EnemyColor;
    public Color SplineColor;
}
