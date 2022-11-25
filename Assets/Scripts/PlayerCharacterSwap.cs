using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerCharacterSwap : MonoBehaviour
{
    [SerializeField]
    private Image _characterImage;

    [SerializeField]
    private TMP_Dropdown _dropDown;

    public void OnDropDownValueChanged(int selectionIndex)
    {
        _characterImage.sprite = _dropDown.options[selectionIndex].image;
    }
}
