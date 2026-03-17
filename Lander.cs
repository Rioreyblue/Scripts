using UnityEngine;
using UnityEngine.InputSystem;

public class Lander : MonoBehaviour
{

    // Update is called once per frame
    private void Update()
    {
        //  if (Keyboard.current.upArrowKey.isPressed)
        // {
        //     Debug.Log("Up Arrow Key is Pressed");
        // }
        // if (Keyboard.current.downArrowKey.isPressed)
        // {
        //     Debug.Log("Down Arrow Key is Pressed");
        // }
        // if (Keyboard.current.leftArrowKey.isPressed)
        // {
        //     Debug.Log("Left Arrow Key is Pressed");
        // }
        // if (Keyboard.current.rightArrowKey.isPressed)
        // {
        //     Debug.Log("Right Arrow Key is Pressed");
        // }
        

        // Capture horizontal and vertical input as a single "direction"
    Vector2 moveInput = Vector2.zero;

    if (Keyboard.current.upArrowKey.isPressed)    moveInput.y = 1;
    if (Keyboard.current.downArrowKey.isPressed)  moveInput.y = -1;
    if (Keyboard.current.leftArrowKey.isPressed)  moveInput.x = -1;
    if (Keyboard.current.rightArrowKey.isPressed) moveInput.x = 1;

    // Now you have one variable that knows exactly where to go!
    if (moveInput != Vector2.zero)
    {
        Debug.Log($"Moving in direction: {moveInput}");
        // transform.Translate(moveInput * speed * Time.deltaTime);
    }
    }
}
