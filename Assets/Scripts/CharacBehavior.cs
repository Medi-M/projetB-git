using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacBehavior : MonoBehaviour
{
    public Rigidbody2D rb;
    public float vitesse;
    public float maxJump;
    private bool isGrounded = false; // on veut pas que perso soit au sol 
    private bool canDoubleJump = false;
    public GameObject goPan;
    public GameObject gameOverPanel;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity += new Vector2(vitesse, 0);
    }
    // Update is called once per frame
    void Update()// chaque image
    {
        if (Input.GetKeyDown("space"))
        {
            if (isGrounded)
            {
                Jump();
                canDoubleJump = true;
            }
            else if (!isGrounded && canDoubleJump) // si le perso est en l'ai il sautera deux fois
            {
                Jump();
                canDoubleJump = false;
            }
        }
    }


    void Jump()
    {
        rb.velocity += new Vector2(0, maxJump);
    }
    void OnCollisionEnter2D(Collision2D col) // si il rancontre quelquechose
    {
        if (col.gameObject.CompareTag("Groud"))
        {
            isGrounded = true; // si il est au solle
            canDoubleJump = false; // si il est au solle il peut pas sauter deux fois
        }

    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Groud"))
        {
            isGrounded = false;                  // n'est plus au solle et pour indiquer que le personnage est en l'air.

        }
        else if (col.gameObject.CompareTag("Monstre"))
        {
            canvas.SetActive(true);
            Destroy(gameObject);
           
        }
    }
  
    // Appelle la méthode ShowGameOver() du script GameOverPanel attaché au panneau Game Over



}

