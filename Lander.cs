//using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Lander : MonoBehaviour
{
    private Rigidbody2D _playerLander;
    private void Awake()
    {
        _playerLander = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
         if (Keyboard.current.upArrowKey.isPressed)
        {
            _playerLander.AddForce((transform.up));
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            _playerLander.AddForce((transform.down));
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            _playerLander.AddForce((transform.left));
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            _playerLander.AddForce((transform.right));
        }
    }
}
