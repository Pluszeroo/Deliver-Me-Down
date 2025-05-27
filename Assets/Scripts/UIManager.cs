using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;
    private bool isGameOver = false;
    [SerializeField] private GameObject winGameUI;
    [SerializeField] private GameObject scoreUI;

    void Start()
    {
        gameOverUI.SetActive(false);
        winGameUI.SetActive(false);
        scoreUI.SetActive(false);
    }

    //private void Update()
    //if (isGameOver && Input.GetKeyDown(KeyCode.Space))

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void Restart()
    {
        Debug.Log("GetKeyDown.SpacePressed");
        SceneManager.LoadScene("TreeTree");
    }

    public void BackToMenu()
    {
        Debug.Log("ButtonPressed");
        SceneManager.LoadScene("MainMenu");
    }
}
