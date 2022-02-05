using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpStrength = 15f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Now rb is referencing the RigidBody 2D module
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal");  // Unity's built-in keypress movement detection. 1 for right, -1 for left.
        rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);  // Changes x-vel to match the direction
        // rb.AddForce(new Vector2(direction * 5 / Time.deltaTime, 0), ForceMode2D.Impulse);
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
        }
    }

    bool IsGrounded()
    {
        RaycastHit2D target = Physics2D.Raycast(gameObject.transform.position, Vector2.down, 1.2f, LayerMask.GetMask("Terrain"));
        return (target.collider != null);
    }

    
}
