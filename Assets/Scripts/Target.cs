using UnityEngine;

public class Target : MonoBehaviour
{
    public bool hasWon;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hasWon = true;
            Debug.Log("Has won");
        }

    }

}
