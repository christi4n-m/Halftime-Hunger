using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;

    public AppleManager am;
    public SatisManager sm;

    private float satisfactionTimer = 0f;
    private bool EndGame = false;

    public GameOverScreen go;
    int satisfaction = 0;

    public void GameOver()
    {
        go.Setup(satisfaction);
        EndGame = true;
    }

    void Update()
    {
        if (EndGame == false);
        {
            ProcessInputs();
            satisfactionTimer += Time.deltaTime;
            if (satisfactionTimer >= 1f)
            {
                sm.satisfaction -= 2;
                if (sm.satisfaction <= 0)
                {
                    sm.satisfaction = 0;
                    GameOver();
                }
                satisfactionTimer = 0f;
            }
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs() 
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move() 
    {
        rb.linearVelocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            am.appleCount++;
            sm.satisfaction += 5;
        }
    }
   
}
