using UnityEngine;

public class hurtplayer : MonoBehaviour
{
    public int damageAmount = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerhp playerHealth = other.GetComponent<playerhp>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
            }
           
        }
    }
}
