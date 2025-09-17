using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnMove(InputValue value)
    {
        Debug.Log("Input Vector: " + value.Get<Vector2>());
    }
}
