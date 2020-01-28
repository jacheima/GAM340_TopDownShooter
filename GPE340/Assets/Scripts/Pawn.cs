using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void HandleMovement(Vector2 position)
    {
        //set the parameters that control the animations movement
        anim.SetFloat("Horizontal", position.x * speed);
        anim.SetFloat("Vertical", position.y * speed);
    }
}
