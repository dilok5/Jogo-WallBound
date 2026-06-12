using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("References")]
    private Rigidbody2D oRigidbody2D;
    private Animator oAnimator;
    private bool hasPlayedWallJumpSound;

    [Header("Horizontal Movement")]
    public float playerVelocity;
    public bool goingRigth;

    [Header("Jump")]
    public bool onTheFloor;
    public float jumpHeight;
    public float verificationRadiusSize;
    public Transform floorChecker;
    public LayerMask layerFloor;

    [Header("Wall Jump")]
    public bool onTheWall;
    public bool jumpingOnTheWall;
    public float wallJumpForceX;
    public float wallJumpForceY;
    public Transform wallChecker;

    [Header("Checks")]
    public bool playerIsAlive;

    private void Awake()
    {
        oRigidbody2D = GetComponent<Rigidbody2D>();
        oAnimator = GetComponent<Animator>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerIsAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsAlive == true)
        {
            MovePlayer();
            Jump();
            WallJump();
        }
    }

    private void MovePlayer()
    {
        //Cuida do movimento horizontal do jogador
        float horizontalMovement = Input.GetAxis("Horizontal");
        oRigidbody2D.linearVelocity = new Vector2(horizontalMovement * playerVelocity, oRigidbody2D.linearVelocity.y);

        //Espelha o jogador dependendo da sua direção
        if (horizontalMovement > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            goingRigth = true;
        }
        else if (horizontalMovement < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            goingRigth = false;
        }

        //Toca as animações do jogador parado e andando
        if (horizontalMovement == 0 && onTheFloor == true)
        {
            oAnimator.Play("player-idle");
        }
        else if (horizontalMovement != 0 && onTheFloor == true && onTheWall == false)
        {
            oAnimator.Play("player-walk");
        }
    }

    private void Jump()
    {
        //Verifica se o jogador está encostando no chão
        onTheFloor = Physics2D.OverlapCircle(floorChecker.position, verificationRadiusSize, layerFloor);

        //Faz o jogador pular
        if (Input.GetButtonDown("Jump") && onTheFloor == true)
        {
            SFXManager.instance.jumpSound.Play();
            oRigidbody2D.AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }

        //Toca a animação do jogador pulando
        if (onTheFloor == false && onTheWall == false)
        {
            oAnimator.Play("player-jump");
        }
    }

    private void WallJump()
    {
        //Verifica se o jogador está encostando em uma parede
        onTheWall = Physics2D.OverlapCircle(wallChecker.position, verificationRadiusSize, layerFloor);

        //Toca a animação do jogador deslizando na parede
        if (onTheWall == true && onTheFloor == false)
        {
            oAnimator.Play("player-sliding-on-the-wall");
        }

        //Diz que o jogador está na parede e está pulando
        if (Input.GetButtonDown("Jump") && onTheWall == true && onTheFloor == false)
        {
            jumpingOnTheWall = true;
        }

        //Faz o jogador pular na parede (ir na direção oposta dela)
        if (jumpingOnTheWall == true)
        {
            if (!hasPlayedWallJumpSound)
            {
                SFXManager.instance.jumpSound.Play();
                hasPlayedWallJumpSound = true;
            }

            if (goingRigth == true)
            {
                oRigidbody2D.linearVelocity = new Vector2(-wallJumpForceX, wallJumpForceY);
            }
            else
            {
                oRigidbody2D.linearVelocity = new Vector2(wallJumpForceX, wallJumpForceY);
            }

            //Diz para a Unity que o jogador saiu da parede
            Invoke(nameof(fakeWallJump), 0.1f);
        }
    }

    private void fakeWallJump()
    {
        jumpingOnTheWall = false;
        hasPlayedWallJumpSound = false;
    }

    public void BoostPlayer(float impulseForce)
    {
        oRigidbody2D.linearVelocity = new Vector2(oRigidbody2D.linearVelocity.x, 0f);
        oRigidbody2D.AddForce(new Vector2(0f, impulseForce), ForceMode2D.Impulse);
    }
}
