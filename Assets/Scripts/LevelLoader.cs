using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField]
    private string _levelToLoad;

    public void LoadLevel()
    {
        SceneManager.LoadScene(_levelToLoad);
    }
}
