using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoboController : MonoBehaviour
{


    protected Joystick joystick;
    protected Joybutton joybutton;
    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(joystick.Horizontal * 52f, rigidbody.velocity.y);
    }
}
