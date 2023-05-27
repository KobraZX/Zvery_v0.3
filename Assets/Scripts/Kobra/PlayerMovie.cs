using UnityEngine;

public class PlayerMovie : MonoBehaviour
{
    [Header("Скорость персонажа")]
    public float speed = 10f; // скорость персонажа

    [Header("Скорость персонажа при шифте")]
    public float run_speed = 20f; // скорость при шифте

    [Header("Сила прыжка")]
    public int jumpPower = 200; // сила прыжкa
    public int takoyJump;
    public bool active;
   
    public float x;
    public float y;
    float camRayLength = 100f;

    Vector3 moveDirection;
    CharacterController contr;
    int floorMask;
    Animator animator;
    AnimatorStateInfo stateInfo;
    private int state = 1;

    public GameObject SwordA;
    public GameObject SwordB;
    public GameObject BowA;
    public GameObject BowB;
    public GameObject BookA;
    public GameObject BookB;

    public GameObject missileSpawn;
    public GameObject arrow;
    public GameObject spell;

    public GameObject B;

    void Awake()
    {
        floorMask = LayerMask.GetMask("Floor");
    }

    void Start()
    {
        takoyJump = jumpPower;
        animator = GetComponent<Animator>();
        contr = GetComponent<CharacterController>();
    }

    public bool ground;

    public Rigidbody rb;



    void Update()
    {
        GetInput();
        active = CameraController.active;
        stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        Turning();
        ChangeAnimator();
        ChangeWeapon();
    }

    private void GetInput()
    {
        if (!active)
        {
            return;
        }
        else
        {
            contr.SimpleMove(Vector3.zero);
            animator.SetBool("Run", false);
            if (Input.GetKey(KeyCode.W))
            {
                if (stateInfo.IsName("SwordAttack") || stateInfo.IsName("BowAttack") || stateInfo.IsName("BookAttack"))
                {
                    contr.SimpleMove(Vector3.zero);
                }
                else if (Input.GetKey(KeyCode.LeftShift) & !Input.GetKey(KeyCode.S))
                {
                    animator.SetBool("Run", true);
                    if (PlayerStamina.currentStamina >= PlayerStamina.MinusStamShift2)
                    {
                        moveDirection = transform.forward * run_speed;
                        contr.SimpleMove(moveDirection);
                        PlayerStamina.currentStamina -= PlayerStamina.MinusStamShift2 * Time.deltaTime * 10;
                    }
                    if (PlayerStamina.currentStamina < PlayerStamina.MinusStamShift2)
                    {
                        animator.SetBool("Run", false);
                        moveDirection = transform.forward * speed;
                        contr.SimpleMove(moveDirection);
                    }

                }
                else
                {
                    moveDirection = transform.forward * speed;
                    contr.SimpleMove(moveDirection);
                }
            }

            if (Input.GetKey(KeyCode.A))
            {
                if (stateInfo.IsName("SwordAttack") || stateInfo.IsName("BowAttack") || stateInfo.IsName("BookAttack"))
                {
                    contr.SimpleMove(Vector3.zero);
                }
                else if (Input.GetKey(KeyCode.LeftShift) & !Input.GetKey(KeyCode.S))
                {
                    animator.SetBool("Run", true);
                    if (PlayerStamina.currentStamina >= PlayerStamina.MinusStamShift2)
                    {
                        moveDirection = -transform.right * run_speed;
                        contr.SimpleMove(moveDirection);
                        PlayerStamina.currentStamina -= PlayerStamina.MinusStamShift2 * Time.deltaTime * 10;
                    }
                    if (PlayerStamina.currentStamina < PlayerStamina.MinusStamShift2)
                    {
                        animator.SetBool("Run", false);
                        moveDirection = -transform.right * speed;
                        contr.SimpleMove(moveDirection);
                    }

                }
                else
                {
                    moveDirection = -transform.right * speed;
                    contr.SimpleMove(moveDirection);
                }
            }

            if (Input.GetKey(KeyCode.D))
            {
                if (stateInfo.IsName("SwordAttack") || stateInfo.IsName("BowAttack") || stateInfo.IsName("BookAttack"))
                {
                    contr.SimpleMove(Vector3.zero);
                }
                else if (Input.GetKey(KeyCode.LeftShift) & !Input.GetKey(KeyCode.S))
                {
                    animator.SetBool("Run", true);
                    if (PlayerStamina.currentStamina >= PlayerStamina.MinusStamShift2)
                    {
                        moveDirection = transform.right * run_speed;
                        contr.SimpleMove(moveDirection);
                        PlayerStamina.currentStamina -= PlayerStamina.MinusStamShift2 * Time.deltaTime * 10;
                    }
                    if (PlayerStamina.currentStamina < PlayerStamina.MinusStamShift2)
                    {
                        animator.SetBool("Run", false);
                        moveDirection = transform.right * speed;
                        contr.SimpleMove(moveDirection);
                    }

                }
                else
                {
                    moveDirection = transform.right * speed;
                    contr.SimpleMove(moveDirection);
                }
            }

            if (Input.GetKey(KeyCode.S))
            {
                if (stateInfo.IsName("SwordAttack") || stateInfo.IsName("BowAttack") || stateInfo.IsName("BookAttack"))
                {
                    contr.SimpleMove(Vector3.zero);
                }
                else
                {
                    moveDirection = -transform.forward * speed;
                    contr.SimpleMove(moveDirection);
                }
            }

            Attack();
            
            x = Input.GetAxisRaw("Vertical");
            y = Input.GetAxisRaw("Horizontal");
        }
    }
    void Turning()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit floorHit;
        if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
        {
            Vector3 playerToMouse = floorHit.point - transform.position;
            playerToMouse.y = 0;

            var rotation = Quaternion.LookRotation(playerToMouse);
            rb.MoveRotation(rotation);
        }
    }
    void FixedUpdate()
    {
        animator.SetFloat("Speed", x, 0.1f, Time.deltaTime);
        animator.SetFloat("Direction", y, 0.1f, Time.deltaTime);
    }
    private void ChangeAnimator()
    {
        if (Input.GetAxisRaw("Mouse ScrollWheel") > 0.0f)
        {
            state++;
            if (state > 3) { state = 1; }
            if (state == 1)
            {
                animator.SetTrigger("Sword");
            }
            if (state == 2)
            {
                animator.SetTrigger("Bow");
            }
            if (state == 3)
            {
                animator.SetTrigger("Book");
            }
        }
        else if (Input.GetAxisRaw("Mouse ScrollWheel") < 0.0f) 
        {
            state--;
            if (state < 1) { state = 3; }
            if (state == 1)
            {
                animator.SetTrigger("Sword");
            }
            if (state == 2)
            {
                animator.SetTrigger("Bow");
            }
            if (state == 3)
            {
                animator.SetTrigger("Book");
            }
        }
    }
    private void ChangeWeapon()
    {
        if (state == 1)
        {
            SwordA.SetActive(true);
            SwordB.SetActive(false);
            BowA.SetActive(false);
            BowB.SetActive(true);
            BookA.SetActive(false);
            BookB.SetActive(true);
            foreach (Transform child in transform)
            {
                if (child.name == "ArmorA_body" ||
                    child.name == "ArmorA_boots" ||
                    child.name == "ArmorA_cape" ||
                    child.name == "ArmorA_gauntlets" ||
                    child.name == "ArmorA_helmet" ||
                    child.name == "ArmorA_legs")
                {
                    child.gameObject.SetActive(true);
                }
                else if (child.name == "ArmorC_body" ||
                    child.name == "ArmorC_boots" ||
                    child.name == "ArmorC_cape" ||
                    child.name == "ArmorC_gauntlets" ||
                    child.name == "ArmorC_helmet" ||
                    child.name == "ArmorC_legs" ||
                    child.name == "ArmorB_body" ||
                    child.name == "ArmorB_boots" ||
                    child.name == "ArmorB_gauntlets" ||
                    child.name == "ArmorB_legs")
                {
                    child.gameObject.SetActive(false);
                }
            }
        }
        if (state == 2)
        {
            SwordA.SetActive(false);
            SwordB.SetActive(true);
            BowA.SetActive(true);
            BowB.SetActive(false);
            BookA.SetActive(false);
            BookB.SetActive(true);
            foreach (Transform child in transform)
            {
                if (child.name == "ArmorB_body" ||
                    child.name == "ArmorB_boots" ||
                    child.name == "ArmorB_gauntlets" ||
                    child.name == "ArmorB_legs")
                {
                    child.gameObject.SetActive(true);
                }
                else if (child.name == "ArmorC_body" ||
                    child.name == "ArmorC_boots" ||
                    child.name == "ArmorC_cape" ||
                    child.name == "ArmorC_gauntlets" ||
                    child.name == "ArmorC_helmet" ||
                    child.name == "ArmorC_legs" ||
                    child.name == "ArmorA_body" ||
                    child.name == "ArmorA_boots" ||
                    child.name == "ArmorA_cape" ||
                    child.name == "ArmorA_gauntlets" ||
                    child.name == "ArmorA_helmet" ||
                    child.name == "ArmorA_legs")
                {
                    child.gameObject.SetActive(false);
                }
            }
        }
        if (state == 3)
        {
            SwordA.SetActive(false);
            SwordB.SetActive(true);
            BowA.SetActive(false);
            BowB.SetActive(true);
            BookA.SetActive(true);
            BookB.SetActive(false);
            foreach (Transform child in transform)
            {
                if (child.name == "ArmorC_body" ||
                    child.name == "ArmorC_boots" ||
                    child.name == "ArmorC_cape" ||
                    child.name == "ArmorC_gauntlets" ||
                    child.name == "ArmorC_helmet" ||
                    child.name == "ArmorC_legs")
                {
                    child.gameObject.SetActive(true);
                }
                else if (child.name == "ArmorA_body" ||
                    child.name == "ArmorA_boots" ||
                    child.name == "ArmorA_cape" ||
                    child.name == "ArmorA_gauntlets" ||
                    child.name == "ArmorA_helmet" ||
                    child.name == "ArmorA_legs" ||
                    child.name == "ArmorB_body" ||
                    child.name == "ArmorB_boots" ||
                    child.name == "ArmorB_gauntlets" ||
                    child.name == "ArmorB_legs")
                {
                    child.gameObject.SetActive(false);
                }
            }
        }
    }
    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) & state == 1 && PlayerStamina.currentStamina >= Shop.Minus_Sword)
        {
            animator.SetTrigger("Attack");
            PlayerStamina.currentStamina -= Shop.Minus_Sword;
            
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) & state == 2 && PlayerStamina.currentStamina >= Shop.Minus_Bow)
        {
            animator.SetTrigger("Attack");
            BowShoot();
            PlayerStamina.currentStamina -= Shop.Minus_Bow;
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) & state == 3 && PlayerMana.currentMana >= Shop.Minus_Book)
        {
            animator.SetTrigger("Attack");
            BookShoot();
            PlayerMana.currentMana -= Shop.Minus_Book;
        }
    }
    private void BowShoot()
    {
        GameObject currentArrow = Instantiate(arrow, missileSpawn.transform.position, missileSpawn.transform.rotation);
        currentArrow.GetComponent<Rigidbody>().AddForce(missileSpawn.transform.forward * 100, ForceMode.Impulse);
    }
    private void BookShoot()
    {
        GameObject currentSpell = Instantiate(spell, missileSpawn.transform.position, missileSpawn.transform.rotation);
        currentSpell.GetComponent<Rigidbody>().AddForce(missileSpawn.transform.forward * 30, ForceMode.VelocityChange);
    }
}