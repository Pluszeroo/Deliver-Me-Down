using Unity.VisualScripting;
using UnityEngine;

public class TreeSpin : MonoBehaviour
{
    public float goingDownRate = 0.001f;
    public float spinRate = 0.001f;
    public Transform currentPosition;

    private void Start()
    {
        currentPosition = gameObject.transform;
    }

    private void Update()
    {
        float targetYPosition = transform.position.y - goingDownRate * Time.deltaTime;
        transform.position = new Vector3(currentPosition.transform.position.x, targetYPosition, currentPosition.transform.position.z);

        float targetYRotation = transform.eulerAngles.y - spinRate * Time.deltaTime;
        transform.eulerAngles = new Vector3(0.0f, targetYRotation, 0.0f);
    }

}


