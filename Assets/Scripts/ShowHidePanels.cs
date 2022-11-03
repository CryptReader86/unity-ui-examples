using UnityEngine;

public class ShowHidePanels : MonoBehaviour
{
    public CanvasGroup inventory;
    public CanvasGroup pause;

    private void Start()
    {
        HidePanel(inventory);
        HidePanel(pause);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) && !IsPaused())
        {
            TogglePanelVisibility(inventory);
        }

        if (Input.GetButtonDown("Pause"))
        {
            TogglePanelVisibility(pause);
            ToggleTimeScale();
        }
    }

    private void TogglePanelVisibility(CanvasGroup panel)
    {
        if (IsPanelVisible(panel))
        {
            HidePanel(panel);
        }
        else
        {
            ShowPanel(panel);
        }
    }

    private bool IsPanelVisible(CanvasGroup panel) => panel.alpha == 1;

    private bool IsPaused() => Time.timeScale == 0;

    private void HidePanel(CanvasGroup panel)
    {
        panel.alpha = 0;
        panel.interactable = false;
        panel.blocksRaycasts = false;
    }

    private void ShowPanel(CanvasGroup panel)
    {
        panel.alpha = 1;
        panel.interactable = true;
        panel.blocksRaycasts = true;
    }

    private void ToggleTimeScale()
    {
        Time.timeScale = Time.timeScale == 1 ? 0 : 1;
    }
}
