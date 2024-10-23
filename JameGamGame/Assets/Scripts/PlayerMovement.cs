using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 playerInput;
    private Rigidbody2D rb;
    public float maxHealth;
    public float currHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.linearVelocity = playerInput.normalized * moveSpeed;
    }

    public void Hit(float damage) {
        currHealth -= damage;
    }
}
