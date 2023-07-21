using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SimpleMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D body2d;

    // Start is called before the first frame update
    void Start()
    {
        body2d=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var val = Input.GetAxis("Horizontal");
        body2d.velocity = new Vector2(speed * val,body2d.velocity.y);
        var val2 = Input.GetAxis("Vertical");
        body2d.velocity = new Vector2(body2d.velocity.x, speed * val2);
    }
}
