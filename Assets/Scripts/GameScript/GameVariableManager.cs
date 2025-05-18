using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameVariableManager : MonoBehaviour
{
    public static int retryTimes;
    public static float elapsedTime;
    public static int stageNum;
    public static bool isStarted;
    //public Material[] numMaterial;
    public MaterialScriptableObj MaterialDataBase;
    // Start is called before the first frame update
    void Start()
    {
        retryTimes = 0;
        MaterialDataBase = Resources.Load<MaterialScriptableObj>("MaterialDataBase1");
        SceneManager.LoadSceneAsync("TitleScene", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        if (isStarted)
        {
            retryTimes = 0;
            elapsedTime = 0.0f;
            isStarted = false;
        }
        elapsedTime += Time.deltaTime;
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
