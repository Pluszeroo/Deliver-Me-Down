using UnityEngine;

public class KillObject : MonoBehaviour
{
    private bool hasBeenTouched = false;
    public UIManager Manager;

    private void Start()
    {
        Manager = FindAnyObjectByType<UIManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Kill the player
            other.gameObject.SetActive(false);

        }

        Manager.gameOver();
    }
    
    
   

}
