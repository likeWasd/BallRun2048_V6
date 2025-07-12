using UnityEngine;
using UnityEngine.SceneManagement;

public class Title3Manager : MonoBehaviour
{
    [SerializeField] int defaultStageNum;
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
        GameVariableManager.isStarted = true;
        GameVariableManager.stageNum = defaultStageNum;
        SceneManager.LoadSceneAsync("Game3Scene", LoadSceneMode.Single);
    }

    public void onClickReturnTitleButton()
    {
        SceneManager.LoadSceneAsync("Title3Scene", LoadSceneMode.Single);
    }

    public void onClickReturnSelectButton()
    {
        SceneManager.LoadSceneAsync("GameSelect", LoadSceneMode.Single);
    }
}
