using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    public RigidBody2D rb;
    public float moveSpeed = 5f;
    float horizontalMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(horizontalMovement * moveSpeed, rb.velocity.y);
    }

    public void move(InputAction.CallbackContext context){
        horizontalMovement = context.ReadValue<Vector2>().x; //horiz mvmt
    }
}
