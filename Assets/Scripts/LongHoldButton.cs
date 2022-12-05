using UnityEngine;
using UnityEngine.UI;

public class LongHoldButton : MonoBehaviour
{
    private bool _isPressed;
    private float _pressedStartTime;

    [SerializeField]
    private Image _fillImage;

    [SerializeField]
    private float _pressedFullTime;

    void Update()
    {
        if(_isPressed)
        {
            float currentPressedTime = Time.time - _pressedStartTime;
            _fillImage.fillAmount = currentPressedTime / _pressedFullTime;

            if (currentPressedTime >= _pressedFullTime)
            {
                Debug.Log("Press completed!");
            }
        }
    }

    public void OnPressStatusChanged(bool isPressed)
    {
        _isPressed = isPressed;

        if(_isPressed)
        {
            _pressedStartTime = Time.time;
        }
        else
        {
            _fillImage.fillAmount = 0;
        }
    }
}
