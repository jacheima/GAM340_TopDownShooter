using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

    [SerializeField, Tooltip("The max speed of the player")]
    private float speed = 10f;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        
        
    }

    public void Move(Vector2 direction)
    {
        animator.SetFloat("Horizontal", direction.x * speed);
        animator.SetFloat("Vertical", direction.y * speed);
    }

}
