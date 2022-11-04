using UnityEngine;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour
{
    private Image _dragItem;

    [SerializeField]
    private Canvas _dragCanvas;

    public void StartDrag(Image selectedItem)
    {
        _dragItem = Instantiate(selectedItem, Input.mousePosition, selectedItem.transform.rotation, _dragCanvas.transform);

        _dragItem.SetNativeSize();

        _dragItem.raycastTarget = false;

        _dragItem.transform.localScale *= 1.1f;
    }

    public void Drag()
    {
        _dragItem.transform.position = Input.mousePosition;
    }

    public void StopDrag()
    {
        Destroy(_dragItem.gameObject);
    }

    public void Drop(Image item)
    {
        item.sprite = _dragCanvas.GetComponentInChildren<Image>().sprite;
    }
}
