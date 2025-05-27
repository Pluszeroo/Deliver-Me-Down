using UnityEngine;

public class Line : MonoBehaviour
{
    private LineRenderer lineRenderer;
    [SerializeField]
    private Transform pointOne;

    [SerializeField]
    private Transform pointTwo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.GetPosition(0);
        lineRenderer.GetPosition(1);
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, pointOne.position);
        lineRenderer.SetPosition(1, pointTwo.position);

    }
}
