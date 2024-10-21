using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public TextMeshPro ScoreText;
    public float Speed;
    public float Move;  
    public float Jump;
    public bool isJumping;
    public int Score = 0;

    void Start()
    {
        UpdateScore();
		rb =  GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(Speed * Move, rb.velocity.y);
        
        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, 350)); 
            Debug.Log("Jump"); 
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            isJumping = false;
        }

        if (other.gameObject.CompareTag("Hazard"))
        {
            Die();
        }

        CoinScript coin = other.gameObject.GetComponent<CoinScript>();
        if (coin != null)
        {
            coin.GetBumped();
            Score++;
            UpdateScore();
        }
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            isJumping = true;
        }
    }

    void UpdateScore()
    {
        ScoreText.text = "Score: " + Score;
    }

    void Die()
    {
        SceneManager.LoadScene("Game Over");
    }
}
