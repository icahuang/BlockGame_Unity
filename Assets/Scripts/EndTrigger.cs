using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    //要注意：On是大写
    void OnTriggerEnter()
    {
        //FindObjectOfType<GameManager>().CompleteLevel();
        gameManager.CompleteLevel();
    }
}