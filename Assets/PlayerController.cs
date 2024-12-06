using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    Rigidbody2D rb;
    EntityStats playerStats;
    float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<EntityStats>();
        moveSpeed = playerStats.baseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        MovePosition();
    }

    void MovePosition()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
        
        gameObject.GetComponent<Rigidbody2D>().linearVelocity = movement;

        if( horizontal != 0 && vertical != 0)
        {
            moveSpeed = playerStats.baseSpeed * 0.66f;
        }
        else
        {
            moveSpeed = playerStats.baseSpeed;
        }

    }
}
