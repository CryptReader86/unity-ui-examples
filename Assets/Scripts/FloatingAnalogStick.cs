using UnityEngine;

public class FloatingAnalogStick : MonoBehaviour
{
    private Vector2 _startingPosition;

    private bool _stickAdded;

    [SerializeField]
    private float _dragThreshold = 30;

    [SerializeField]
    private RectTransform _base;
    [SerializeField]
    private RectTransform _stick;
    [SerializeField]
    private CanvasGroup _stickCanvasGroup;

    public void StartDrag()
    {
        _startingPosition = Input.mousePosition;

        _base.anchoredPosition = _startingPosition;
        _stick.anchoredPosition = Vector2.zero;

        _stickAdded = true;

        _stickCanvasGroup.alpha = 1;
    }

    public void Drag()
    {
        Vector2 currentPosition = Input.mousePosition;

        float xPosition = 0;
        float yPosition = 0;

        if (currentPosition.x <= _startingPosition.x - _dragThreshold)
        {
            Debug.Log("Left");
            xPosition = -10;
        }
        else if (currentPosition.x >= _startingPosition.x + _dragThreshold)
        {
            Debug.Log("Right");
            xPosition = 10;
        }

        if (currentPosition.y <= _startingPosition.y - _dragThreshold)
        {
            Debug.Log("Down");
            yPosition = -10;
        }
        else if (currentPosition.y >= _startingPosition.y + _dragThreshold)
        {
            Debug.Log("Up");
            yPosition = 10;
        }

        _stick.anchoredPosition = new Vector2(xPosition, yPosition);
    }

    public void EndDrag()
    {
        _stick.anchoredPosition = Vector2.zero;
    }

    private void Update()
    {
        if(_stickAdded)
        {
            Drag();

            if (Input.GetMouseButtonUp(0))
            {
                _stickAdded = false;

                _stickCanvasGroup.alpha = 0;

                EndDrag();
            }
        }
    }
}
