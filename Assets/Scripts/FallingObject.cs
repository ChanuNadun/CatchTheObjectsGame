using UnityEngine;

public class FallingObject : MonoBehaviour
{
    void OnTrigger2D() 
    {
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                
                Destroy(gameObject);
            }
            else if (other.CompareTag("Ground"))
            {
                
                Destroy(gameObject);
            }
        }
    }
}
