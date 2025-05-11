using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickStartButton()
    {
        SceneManager.LoadSceneAsync("GameScene1", LoadSceneMode.Single);
    }

    public void onClickReturnButton()
    {
        SceneManager.LoadSceneAsync("TitleScene", LoadSceneMode.Single);
    }
}
