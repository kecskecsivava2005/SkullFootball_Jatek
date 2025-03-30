using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalDetection : MonoBehaviour
{
    public Transform ball; 
    public Vector3 initialPosition; 
    public Text goalCounterText; 
    private int goalCount = 0; 
    void Start()
    {
      
        initialPosition = ball.position;
        UpdateGoalCounter();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball")) 
        {
            goalCount++; 
            UpdateGoalCounter(); 
            ResetBallPosition(); 
        }
    }

    void ResetBallPosition()
    {
        ball.position = initialPosition;
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.zero; 
            rb.angularVelocity = 0; 
        }
    }

    void UpdateGoalCounter()
    {
        goalCounterText.text = " "+goalCount;
    }
}
