using UnityEngine;
using UnityEngine.SceneManagement;

public class Title1Manager : MonoBehaviour
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
        SceneManager.LoadSceneAsync("Game1Scene", LoadSceneMode.Single);
    }

    public void onClickReturnTitleButton()
    {
        SceneManager.LoadSceneAsync("Title1Scene", LoadSceneMode.Single);
    }

    public void onClickReturnSelectButton()
    {
        SceneManager.LoadSceneAsync("GameSelect", LoadSceneMode.Single);
    }
}
