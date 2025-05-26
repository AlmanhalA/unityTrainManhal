using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform _playerTransform;
    public Rigidbody _playerRigidBody;
    float _playerSpeed = 5f;

    void Update()
    {
        float xmove = Input.GetAxis("Horizontal");
        float zmove = Input.GetAxis("Vertical");
        float delta = Time.deltaTime;

        _playerRigidBody.position += new Vector3(xmove, 0, zmove) * _playerSpeed * delta;
        bool isPressedSpace = Input.GetKeyDown(KeyCode.Space);
         if (isPressedSpace)
        {
            Vector3 force = new Vector3(0, 150, 0);
            _playerRigidBody.AddForce(force);
        }

    }
}
