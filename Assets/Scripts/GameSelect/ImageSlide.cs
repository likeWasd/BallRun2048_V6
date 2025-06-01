using UnityEngine;

public class ImageSlide : MonoBehaviour
{
    [SerializeField] RectTransform tallManRunRT;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
            tallManRunRT.anchoredPosition += new Vector2(10f, 0f);
        }
    }
}
