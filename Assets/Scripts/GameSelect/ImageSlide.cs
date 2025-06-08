using UnityEngine;
using DG.Tweening;

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
            leftPressed();
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightPressed();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startPressed();
        }
    }

    public void leftPressed()
    {
        if (nowSelectedGame > 1) {
            nowSelectedGame--;
            tallManRunRT.DOComplete();
            tallManRunRT.DOAnchorPosX(600f, 1f).SetRelative(true);
        }
    }

    public void rightPressed()
    {
        if (nowSelectedGame < maxGameNumber)
        {
            nowSelectedGame++;
            tallManRunRT.DOComplete();
            tallManRunRT.DOAnchorPosX(-600f, 1f).SetRelative(true);
        }
    }

    public void startPressed()
    {

    }
}
