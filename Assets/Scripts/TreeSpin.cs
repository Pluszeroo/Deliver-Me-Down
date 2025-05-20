using UnityEngine;

public class TreeSpin : MonoBehaviour
{
    public float goingDownRate = 0.001f;
    public float spinRate = 0.001f;
    public Transform currentPosition;
    public bool isGameOver = false;
    private UIManager uiManager;

    private void Start()
    {
        uiManager = FindAnyObjectByType<UIManager>();
        currentPosition = gameObject.transform;
    }

    private void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Pressed");
            uiManager.Restart();
        }

        else if (!isGameOver)
        {
            float targetYPosition = transform.position.y - goingDownRate * Time.deltaTime;
            transform.position = new Vector3(currentPosition.transform.position.x, targetYPosition, currentPosition.transform.position.z);

            float targetYRotation = transform.eulerAngles.y - spinRate * Time.deltaTime;
            transform.eulerAngles = new Vector3(0.0f, targetYRotation, 0.0f);
        }
    }

}


