using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;




public class player : MonoBehaviour
{
    [SerializeField] private float speed; 
    [SerializeField] private float maxspeed; 

    private SpriteRenderer spriterenderer;
    private Animator animator;
    private Rigidbody2D rb2D;
    private Controls controls;
    private float direction;
    private bool moving;


    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Main.Move.performed += MovePerformed;
        controls.Main.Grav.performed += GravPerformed;
        controls.Main.Move.canceled += MoveCanceled;
        controls.Main.Ghost.performed += GhostPerformed;
    }

    private void MoveCanceled(InputAction.CallbackContext obj)
    {
        direction = 0;
        moving = false;
    }


    private void MovePerformed(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<float>();
        if (direction > 0)
        {
            spriterenderer.flipX = true;
        }
        else 
        {
            spriterenderer.flipX = false;
        }
        moving = true;
    }

    private void GravPerformed(InputAction.CallbackContext obj)
    {
        rb2D.gravityScale *= -1;
        if (rb2D.gravityScale < 0)
        {
            spriterenderer.flipY = true;
        }
        else
        {
            spriterenderer.flipY = false;
        }
    }

    private void GhostPerformed(InputAction.CallbackContext obj) //Quand on appuie sur Z (activation du ghost mode)
    {
        StartCoroutine(GhostTimer());
    }

    private IEnumerator GhostTimer() 
    {
        gameObject.layer = 11;                            //On passe le player sur le layer 11 (précédemment sur le layer 8)
        spriterenderer = GetComponent<SpriteRenderer>();  //On stocke le psrite renderer du player dans la variable spriterenderer
        spriterenderer.color = Color.cyan;                //On change la couleur du sprite du player en cyan
        yield return new WaitForSeconds(2);               //On attend 2 secondes (durée du ghost mode)
        gameObject.layer = 8;                             //On repasse le player sur le layer 8
        spriterenderer.color = Color.white;               //On réinitialise la couleur du sprite (couleur de base)
    }

    void Start() 
    {
        rb2D = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(moving == true)
        {
            animator.SetBool("moving", true);
        }
        
        if (moving == false)
        {
            animator.SetBool("moving", false);
        }
    }

    void FixedUpdate()
    {
        var horizontalSpeed = Mathf.Abs(rb2D.velocity.x);
        if (horizontalSpeed < maxspeed)
        {
            rb2D.AddForce(new Vector2(speed * direction, 0));
        }
    }
}