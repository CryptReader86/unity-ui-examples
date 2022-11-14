using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;

public class AnimateText : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _messageText;

    [SerializeField]
    private List<string> _messages = new List<string>();

    [SerializeField]
    private string _nextScene;

    private int _messageIndex;
    private int _characterIndex;

    private Coroutine _animateTextCoroutine;

    void Start()
    {
        _animateTextCoroutine = StartCoroutine(PrintText());
    }

    public void Proceed()
    {
        var textToPrint = _messages[_messageIndex];

        if (_characterIndex < textToPrint.Length)
        {
            StopCoroutine(_animateTextCoroutine);

            _messageText.text = textToPrint;
            _characterIndex = textToPrint.Length;
        }
        else
        {
            _messageIndex++;

            if(_messageIndex >= _messages.Count)
            {
                SceneManager.LoadScene(_nextScene);
            }
            else
            {
                _characterIndex = 0;

                _animateTextCoroutine = StartCoroutine(PrintText());
            }
        }
    }

    private IEnumerator PrintText()
    {
        var textToPrint = _messages[_messageIndex];

        for(int i = 0; i <= textToPrint.Length; i++)
        {
            _messageText.text = textToPrint.Substring(0, i);

            _characterIndex++;

            yield return new WaitForSeconds(0.1f);
        }
    }
}
