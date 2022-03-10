using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    //OncollisionEnter()函数在脚本捆绑的物体，发生碰撞时触发
    //参数Collision:
    private void OnCollisionEnter(Collision collisionInfo)
    {
        //1
        //Debug.Log("Hit something");

        //2
        //Debug.Log(collisionInfo.collider.name);

        //3
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("I hit the Obstacle!");
        }
        if(collisionInfo.collider.tag == "Ground")
        {
            Debug.Log("I hit the ground!");
        }

        //4 当物体撞到带有Obstacle标签的物体时，取消PlayerMovement脚本，使其停止受到力
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            //Unity的特殊函数1：寻找对应type的对象
            FindObjectOfType<GameManager>().EndGame();
            //Unity的特殊函数2：寻找对象中的特定component
            //GetComponent<Transform>();

        }
    }
}
