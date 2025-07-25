using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyGateScript : MonoBehaviour
{
    /// <summary>
    /// 鍵の個数を変える値
    /// </summary>
    public int valueChangingKey;
    /// <summary>
    /// 鍵の個数をどうやって変化させるか
    /// </summary>
    public enum KeyOperators
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    public KeyOperators keyOperatorType;
    [SerializeField] TextMeshProUGUI tmpGateKeyCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void Create(int defaultChangingKey, DiamondGateScript.DiamondOperators op)
    {
        valueChangingKey = defaultChangingKey;
        switch (keyOperatorType)
        {
            case KeyOperators.Add:
                tmpGateKeyCount.text = $"+{valueChangingKey}";
                break;
            case KeyOperators.Subtract:
                tmpGateKeyCount.text = $"-{valueChangingKey}";
                break;
            case KeyOperators.Multiply:
                tmpGateKeyCount.text = $"×{valueChangingKey}";
                break;
            case KeyOperators.Divide:
                tmpGateKeyCount.text = $"÷{valueChangingKey}";
                break;
        }
    }
}
