using UnityEngine;

public class ShowHidePanels : MonoBehaviour
{
    public CanvasGroup inventory;
    public CanvasGroup pause;

    public Animator inventoryAnimator;
    public Animator pauseAnimator;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) && !IsPaused())
        {
            TogglePanelVisibility(inventory, inventoryAnimator);
        }

        if (Input.GetButtonDown("Pause"))
        {
            TogglePanelVisibility(pause, pauseAnimator);
            ToggleTimeScale();
        }
    }

    private void TogglePanelVisibility(CanvasGroup panel, Animator animator)
    {
        if (IsPanelVisible(panel))
        {
            animator.SetTrigger("FadeOut");
        }
        else
        {
            animator.SetTrigger("FadeIn");
        }
    }

    private bool IsPanelVisible(CanvasGroup panel) => panel.alpha == 1;

    private bool IsPaused() => Time.timeScale == 0;

    private void ToggleTimeScale()
    {
        Time.timeScale = Time.timeScale == 1 ? 0 : 1;
    }
}
