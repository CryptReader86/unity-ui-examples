using UnityEngine;

public class ShowHidePanels : MonoBehaviour
{
    public CanvasGroup inventory;
    private void Start()
    {
        HideInventory();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            if(IsInventoryVisible())
            {
                HideInventory();
            }
            else
            {
                ShowInventory();
            }
        }
    }

    private bool IsInventoryVisible() => inventory.alpha == 1;

    private void HideInventory()
    {
        inventory.alpha = 0;
        inventory.interactable = false;
        inventory.blocksRaycasts = false;
    }

    private void ShowInventory()
    {
        inventory.alpha = 1;
        inventory.interactable = true;
        inventory.blocksRaycasts = true;
    }
}
