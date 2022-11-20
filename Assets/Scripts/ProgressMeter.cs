using UnityEngine;
using UnityEngine.UI;

public class ProgressMeter : MonoBehaviour
{
    [SerializeField]
    private uint _health;
    [SerializeField]
    private uint _totalHealth;
    [SerializeField]
    private RectTransform _healthBar;
    [SerializeField]
    private Image _progressMeter;

    private void Update()
    {
        if(_health > _totalHealth)
            _health = _totalHealth;

        float percentHealth = (float)_health / _totalHealth;

        _healthBar.localScale = new Vector2(percentHealth, 1.0f);

        _progressMeter.fillAmount = percentHealth;
    }
}
