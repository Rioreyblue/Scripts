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
        //  if (Keyboard.current == null) return;

         if (Keyboard.current.upArrowKey.isPressed)
        {
            _playerLander.AddForce((transform.up * Time.deltaTime));
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
           _playerLander.AddForce((-transform.up * Time.deltaTime));
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
           _playerLander.AddForce((-transform.right * Time.deltaTime));
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
           _playerLander.AddForce((transform.right * Time.deltaTime));
        }
    }
}
