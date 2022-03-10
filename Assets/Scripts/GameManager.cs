using UnityEngine;
//要读取scene，需要导入这个库
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);    //先delay一会儿，再让场景重新加载，delay时间为restartDelay
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        //for test:
        //Debug.Log("LEVEL COMPLETE!");
        completeLevelUI.SetActive(true);
    }

}