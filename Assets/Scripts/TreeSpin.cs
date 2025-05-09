using UnityEngine;

public class TreeSpin : MonoBehaviour
{
    public float goingDownRate = 0.001f;
    public float spinRate = 0.001f;

    private void Update()
    {
        float targetYPosition = transform.position.y - goingDownRate * Time.deltaTime;
        transform.position = new Vector3(0.0f, targetYPosition, 0.0f);

        float targetYRotation = transform.eulerAngles.y - spinRate * Time.deltaTime;
        transform.eulerAngles = new Vector3(0.0f, targetYRotation, 0.0f);
    }
}
