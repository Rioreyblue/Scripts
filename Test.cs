using UnityEngine;

public class Test : MonoBehaviour
{
    //fuel
    public int _isFuel = 100;
    //speed
    public float isSpeed = 5.5f;
    //name
    public string landerName = "Player";
    //condition
    public bool isLanded = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Debug.Log("Welcome" + landerName);
    }

    // Update is called once per frame
    private void Update()
    {
        if (_isFuel > 0)
        {
            Debug.Log($"Player {landerName} has enough fuel");
        }
        else if (_isFuel < 20)
        {
           Debug.Log($"Player {landerName} almost out of fuel.");
        }
        else
        {
            Debug.Log($"Player {landerName} is out of fuel!");
        }
    }
}
