using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerScripts : MonoBehaviour
{

    private Rigidbody2D _mainPlayerLander; 
   private void Awake()
    {
        _mainPlayerLander = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            _mainPlayerLander.AddForce(transform.up * Time.deltaTime);
        }

        // if (Keyboard.current.downArrowKey.isPressed)
        // {
        //     _mainPlayerLander.AddForce(Transform.down * Time.deltaTime);
        // }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            _mainPlayerLander.AddTorque(+5 * Time.deltaTime);
        }

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            _mainPlayerLander.AddTorque(-5 * Time.deltaTime);
        }
    }
}
