using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyController : MonoBehaviour
{
    public float flapPower = 3;
    private Rigidbody2D _rb;
    private bool _isDead;
    
    void Start()
    {
        
        _rb = GetComponent<Rigidbody2D>();
        _rb.simulated = false;
        Input.simulateMouseWithTouches = true;
    }

    void Update()
    {
        if (_isDead) return;
        
        if (Input.GetMouseButtonDown(0))
        {
            if (_rb.simulated)
            {
                _rb.velocity = new Vector2(_rb.velocity.x, flapPower);
            }
            else
            {
                _rb.simulated = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        StartCoroutine(Co_OnDeath());
    }

    IEnumerator Co_OnDeath()
    {
        _isDead = true;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}