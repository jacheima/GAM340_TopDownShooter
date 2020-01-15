using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       player.Move(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }
}
