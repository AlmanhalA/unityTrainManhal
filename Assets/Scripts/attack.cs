using UnityEngine;

public class attack : MonoBehaviour
{
    private Collider attackCollider;

    void Start()
    {
        // Find the "Attack" collider attached to this GameObject or its children
        attackCollider = GetComponentInChildren<BoxCollider>(includeInactive: true);
       
        // collider disabled at start
        if (attackCollider != null)
        {
            attackCollider.enabled = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && attackCollider != null)
        {
            attackCollider.enabled = !attackCollider.enabled;
        }
    }
}
