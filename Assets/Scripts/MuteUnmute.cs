using UnityEngine;
using UnityEngine.UI;

public class MuteUnmute : MonoBehaviour
{
    private bool _isMusicMuted;
    private bool _isSoundMuted;

    [SerializeField]
    private Image _musicImage;
    [SerializeField]
    private Image _soundImage;

    [SerializeField]
    private Sprite _musicOnSprite;
    [SerializeField]
    private Sprite _musicOffSprite;

    [SerializeField]
    private Sprite _soundOnSprite;
    [SerializeField]
    private Sprite _soundOffSprite;

    public void ToggleMusicMute()
    {
        _isMusicMuted = !_isMusicMuted;

        _musicImage.sprite = _isMusicMuted ? _musicOffSprite : _musicOnSprite;
    }

    public void ToggleSoundMute()
    {
        _isSoundMuted = !_isSoundMuted;

        _soundImage.sprite = _isSoundMuted ? _soundOffSprite : _soundOnSprite;
    }
}
