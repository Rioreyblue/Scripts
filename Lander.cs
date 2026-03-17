using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Lander : MonoBehaviour
{

    // Update is called once per frame
    private void Update()
    {
         if (Keyboard.current.upArrowKey.isPressed)
        {
            Debug.Log("Up Arrow Key is Pressed");
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            Debug.Log("Down Arrow Key is Pressed");
        }
    }
}
