using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{

    Vector2 rawInput;
    Vector2 velocity = Vector2.zero;
    float acceleration = 10f;
    float deaccleration = 4f;
    float moveSpeed = 5f;

    private void Start()
    {
        
    }
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 delta = rawInput * moveSpeed * Time.deltaTime;
        transform.position += delta;
    }

    void OnMove(InputValue value) 
    {
        rawInput = value.Get<Vector2>();
        Debug.Log(rawInput);
    }    
    
}
