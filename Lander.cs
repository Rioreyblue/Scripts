using UnityEngine;
using UnityEngine.InputSystem;

public class Lander : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
         if (Keyboard.current.arrowUpkey.isPressed)
        {
            Debug.Log("Up Arrow Key is Pressed");
        }
    }
}
