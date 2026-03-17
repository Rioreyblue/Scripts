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
            _playerLander.addForce(new Vector2(0,1));
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            Debug.Log("Down Arrow Key is Pressed");
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            Debug.Log("Left Arrow Key is Pressed");
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            Debug.Log("Right Arrow Key is Pressed");
        }
    }
}
