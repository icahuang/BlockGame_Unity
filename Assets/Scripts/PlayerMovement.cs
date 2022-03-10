//using System.Collections;
//using System.Collections.Generic;
//视频教程中删掉了这两行
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 200f;
    public float jumpForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World!");
        //rb.useGravity = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {   //ForceMode.VelocityChange: beginner tutorial E06中，将力的作用改变到速度上，而不是直接作用到物体上，使得左右的方向控制的反应更快，体验更好
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Space))    //KeyCode.Space 即空格
        {
            rb.AddForce(0, jumpForce, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
