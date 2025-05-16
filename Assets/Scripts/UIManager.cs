using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;
    private bool isGameOver = false;

    void Start()
    {
        gameOverUI.SetActive(false);
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void Restart()
    {
        Debug.Log("ButtonPressed");
        SceneManager.LoadScene("TreeTree");
    }

    public void BackToMenu()
    {
        Debug.Log("ButtonPressed");
        SceneManager.LoadScene("MainMenu");
    }
}
