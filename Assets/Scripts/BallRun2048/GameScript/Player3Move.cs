using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player3Move : MonoBehaviour
{
    // プレイヤーが進むスピード(FはForward)
    int moveSpeedF;
    // プレイヤーが進むスピード(LRはLeftRight)
    int moveSpeedLR;
    GameVariableManager ram;
    [SerializeField] TextMeshPro sphereNumObj;
    int playerNum;
    int playerNumExp;
    int playerNumKilo;
    [SerializeField] int defaultPlayerNumExp;
    Renderer playerMaterial;
    int eachWallNum;
    float clearElapsedTime;
    int clearRetryTimes;
    bool isClear;
    [SerializeField] TextMeshProUGUI stringTextGoal;
    [SerializeField] TextMeshProUGUI stringTextResult;
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI retriedText;
    [SerializeField] GameObject returnButton;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeedF = defaultPlayerNumExp + 5;
        moveSpeedLR = 10;
        playerNumExp = defaultPlayerNumExp;
        playerNum = (int)Mathf.Pow(2, playerNumExp);
        playerNumKilo = playerNum / 1024;
        playerMaterial = gameObject.GetComponent<Renderer>();
        ram = GameObject.Find("RAM").gameObject.GetComponent<GameVariableManager>();
        //playerMaterial.material = ram.numMaterial[playerNumExp - 1];
        playerMaterial.material = ram.MaterialDataBase.Sphere[playerNumExp - 1];
        if (playerNumExp >= 10)
        {
            sphereNumObj.text = playerNumKilo + "k";
        }
        else
        {
            sphereNumObj.text = playerNum.ToString();
        }
        isClear = false;
        stringTextGoal.enabled = false;
        stringTextResult.enabled = false;
        timeText.enabled = false;
        retriedText.enabled = false;
        returnButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 220 || GameVariableManager.stageNum != 3)
        {
            transform.position += moveSpeedF * transform.forward * Time.deltaTime;
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= moveSpeedLR * transform.right * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += moveSpeedLR * transform.right * Time.deltaTime;
            }
        }
        else
        {
            if (!isClear)
            {
                clearElapsedTime = GameVariableManager.elapsedTime;
                clearRetryTimes = GameVariableManager.retryTimes;
                timeText.text = clearElapsedTime.ToString("f3") + "s";
                retriedText.text = clearRetryTimes.ToString();
                stringTextGoal.enabled = true;
                stringTextResult.enabled = true;
                timeText.enabled = true;
                retriedText.enabled = true;
                returnButton.SetActive(true);
                isClear = true;
            }
            //UnityEditor.EditorApplication.isPaused = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Thorn") && playerNum >= 4)
        {
            playerNum /= 2;
            playerNumExp--;
            playerMaterial.material = ram.MaterialDataBase.Sphere[playerNumExp - 1];
            sphereNumObj.text = playerNum.ToString();
            moveSpeedF -= 2;
            if (moveSpeedF < 6)
            {
                moveSpeedF = 6;
            }
        }
        if (collision.gameObject.CompareTag("Sphere"))
        {
            if (collision.gameObject.GetComponent<EachObject>().objNum == playerNum)
            {
                Destroy(collision.gameObject);
                playerNumExp++;
                playerNum = (int)Mathf.Pow(2, playerNumExp);
                playerNumKilo = playerNum / 1024;
                playerMaterial.material = ram.MaterialDataBase.Sphere[playerNumExp - 1];
                if (playerNumExp >= 10)
                {
                    sphereNumObj.text = playerNumKilo + "k";
                }
                else
                {
                    sphereNumObj.text = playerNum.ToString();
                }
                moveSpeedF += 2;
                if (moveSpeedF > 17)
                {
                    moveSpeedF = 17;
                }
            }
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            eachWallNum = collision.gameObject.GetComponent<EachObject>().objNum;
            if (playerNum >= eachWallNum)
            {
                Destroy(collision.gameObject);
                if (GameVariableManager.stageNum < 3)
                {
                    GameVariableManager.stageNum++;
                    SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Single);
                }
                /*
                moveSpeedF = 6;
                objNumExp = 1;
                playerMaterial = gameObject.GetComponent<Renderer>();
                playerMaterial.material = objNumMaterial[objNumExp - 1];
                playerNum = (int)Mathf.Pow(2, objNumExp);
                sphereNumObj.text = playerNum.ToString();
                */
            }
            else
            {
                GameVariableManager.retryTimes++;
                SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Single);
            }
        }
    }
}
