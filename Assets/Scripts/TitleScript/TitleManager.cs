using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
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
        SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Single);
    }

    public void onClickReturnButton()
    {
        SceneManager.LoadSceneAsync("TitleScene", LoadSceneMode.Single);
    }
}
