using UnityEngine;
using UnityEngine.SceneManagement;

public class Title2Manager : MonoBehaviour
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
        SceneManager.LoadSceneAsync("Game2Scene", LoadSceneMode.Single);
        SceneManager.LoadSceneAsync("Game2EnemyGenerator", LoadSceneMode.Additive);
    }

    public void onClickReturnTitleButton()
    {
        SceneManager.LoadSceneAsync("Title2Scene", LoadSceneMode.Single);
    }

    public void onClickReturnSelectButton()
    {
        SceneManager.LoadSceneAsync("GameSelect", LoadSceneMode.Single);
    }
}
