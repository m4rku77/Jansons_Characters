using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rTransform;
    public Canvas canv;

    void Start()
    {
        rTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Izdarīts klikšis uz velkama objekta!");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Uzsākta vilkšana!");
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Convert mouse position to canvas space
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canv.transform as RectTransform, eventData.position, canv.worldCamera, out Vector2 localPoint);

        // Set the position of the RectTransform to the calculated local point
        rTransform.localPosition = localPoint;

        Debug.Log("x=" + localPoint.x + " un y=" + localPoint.y);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Objekts atlaists, vilkšana pārtraukta!");
    }
}
