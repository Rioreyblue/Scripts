using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerScripts : MonoBehaviour
{

    private Rigidbody2D _playerLander; 
   private void Awake()
    {
        _playerLander = GetComponents<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            _playerLander.AddForce(Transform.up * Time.deltaTime);
        }
    }
}
