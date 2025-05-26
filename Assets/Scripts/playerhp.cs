using UnityEngine;

public class playerhp : MonoBehaviour
{
    public int currentHealth = 100;

    public void TakeDamage(int amount)
    {
        if (currentHealth != 0)
        {
        currentHealth -= amount;
        Debug.Log("Current HP: " + currentHealth);

        
        }
    }
}
