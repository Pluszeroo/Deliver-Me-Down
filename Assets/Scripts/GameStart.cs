using UnityEngine;

public class GameStart : MonoBehaviour
{
    private bool gameStart;
    public bool canJump;
    [SerializeField]
    private GameObject startScreen;
    [SerializeField] private GameObject scoreUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canJump = false;
        gameStart = false;
        startScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStart && Input.GetKeyUp(KeyCode.Space))
        {
            Time.timeScale = 1f;
            gameStart = true;
            startScreen.SetActive(false);
            scoreUI.SetActive(true);
        }

        if (gameStart)
        {
            canJump = true;
        }
    }
}
