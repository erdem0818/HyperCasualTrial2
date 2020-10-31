using UnityEngine;
using UnityEngine.EventSystems;

public class DeleteAllPrefs : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerPrefs.DeleteAll();
    }
}
