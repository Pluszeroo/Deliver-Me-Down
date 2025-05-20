using UnityEngine;

public class KillObject : MonoBehaviour
{
    private bool hasBeenTouched = false;
    public UIManager Manager;
    private TreeSpin spin;

    private void Start()
    {
        Manager = FindAnyObjectByType<UIManager>();
        spin = FindAnyObjectByType<TreeSpin>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Kill the player
            other.gameObject.SetActive(false);
            spin.isGameOver = true;

            Debug.Log("GameOver");

        }

        Manager.gameOver();
    }
    
    
   

}
