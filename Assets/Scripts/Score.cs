using UnityEngine;
//需要用到Text对象类型，故添加Un ityEngine.UI
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    //public GameObject player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");   //参数("0")作用：输出整数，抛弃小数点后的数字
        //scoreText.text = player.transform.position.z.ToString();
    }
}
