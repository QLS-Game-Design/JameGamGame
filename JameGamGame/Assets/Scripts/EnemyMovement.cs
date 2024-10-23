using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public float speed = 0;
    public int damage = 20;
    public float attackCooldown = 1f;
    public float attackRange = 3f;
    private float attackTimer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed*Time.deltaTime);

        if (player.transform != null)
        {
            attackTimer += Time.deltaTime;
            if (attackTimer >= attackCooldown && Vector2.Distance(transform.position, player.transform.position) <= attackRange)
            {
                AttackPlayer();
                attackTimer = 0f;
            }
        }
    }

    private void AttackPlayer()
    {
        if (player.transform != null)
        {
            PlayerMovement playerMovement = player.transform.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                playerMovement.Hit(damage);
            }
        }
    }
}
