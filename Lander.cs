using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Lander : MonoBehaviour
{
    private Rigidbody2D _playerLander;
    private void Awake()
    {
        _playerLander = GetComponent<Rigidbody2D>();
    }

    private void Fixedupdate()
    {
         if (Keyboard.current.upArrowKey.isPressed)
        {
            _playerLander.addForce((transform.up));
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            _playerLander.addForce((transform.down));
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            _playerLander.addForce((transform.left));
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            _playerLander.addForce((transform.right));
        }
    }
}
