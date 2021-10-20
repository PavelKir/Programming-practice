using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class StartMenu: MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        GameManager.Instance.StartNewGame();
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
