using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImageSlide : MonoBehaviour
{
    [SerializeField] RectTransform tallManRunRT;
    [SerializeField] int nowSelectedGame;
    public int maxGameNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nowSelectedGame = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //tallManRunRT.anchoredPosition += new Vector2(10f, 0f);
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LeftPressed();
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            RightPressed();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartPressed();
        }
    }

    public void LeftPressed()
    {
        if (nowSelectedGame > 1) {
            nowSelectedGame--;
            tallManRunRT.DOComplete();
            tallManRunRT.DOAnchorPosX(600f, 1f).SetRelative(true);
        }
    }

    public void RightPressed()
    {
        if (nowSelectedGame < maxGameNumber)
        {
            nowSelectedGame++;
            tallManRunRT.DOComplete();
            tallManRunRT.DOAnchorPosX(-600f, 1f).SetRelative(true);
        }
    }

    public void StartPressed()
    {
        if (nowSelectedGame == 1)
        {
            SceneManager.LoadSceneAsync("Title1Scene", LoadSceneMode.Single);
        }
        if (nowSelectedGame == 2)
        {
            SceneManager.LoadSceneAsync("Title2Scene", LoadSceneMode.Single);
        }
        if (nowSelectedGame == 3)
        {
            SceneManager.LoadSceneAsync("FirstLoadScene", LoadSceneMode.Single);
        }
    }
}
