using TMPro;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    /// <summary>
    /// ダイヤモンドの個数
    /// </summary>
    private int _diamondCount;
    /// <summary>
    /// 鍵の個数
    /// </summary>
    private int _keyCount;
    /// <summary>
    /// ダイヤモンドの個数の合計
    /// </summary>
    private int _totalDiamondCount;
    [SerializeField] private TextMeshProUGUI tmpDiamondCount;
    [SerializeField] private TextMeshProUGUI tmpkeyCount;
    [SerializeField] private TextMeshProUGUI ScoreText;
    // Start is called before the first frame update
    private void Start()
    {
        // _totalDiamondCount = totalDiaCouDefVal;
        _diamondCount = 0; // デバッグ中は0をdiamondDefaultValueにする
    }

    // Update is called once per frame
    private void Update()
    {
        _diamondCount = Mathf.Clamp(_diamondCount, 0, _diamondCount);
        tmpDiamondCount.text = "Diamond " + _diamondCount.ToString();
    }

    // ダイヤモンドの個数をセットする
    public int Set(int value)
    {
        _diamondCount = value;
        return _diamondCount;
    }

    // ダイヤモンドの数を変える
    public int Change(DiamondGateScript.DiamondOperators op, int value)
    {
        switch (op)
        {
            // opがAddだった場合
            case DiamondGateScript.DiamondOperators.Add:
                Add(value);
                break;
            // opがSubtractだった場合
            case DiamondGateScript.DiamondOperators.Subtract:
                Subtract(value);
                break;
            // opがMultiplyだった場合
            case DiamondGateScript.DiamondOperators.Multiply:
                Multiply(value);
                break;
            // opがDivideだった場合
            case DiamondGateScript.DiamondOperators.Divide:
                Divide(value);
                break;
        }
        return _diamondCount;
    }

    // ダイヤモンドの個数を増やす(足し算する)
    private int Add(int value)
    {
        _diamondCount += value;
        return _diamondCount;
    }

    // ダイヤモンドの個数を減らす(引き算する)
    private int Subtract(int value)
    {
        _diamondCount -= value;
        return _diamondCount;
    }

    // ダイヤモンドの個数を掛ける(掛け算する)
    private int Multiply(int value)
    {
        _diamondCount *= value;
        return _diamondCount;
    }

    // ダイヤモンドの個数を割る(割り算する)
    private int Divide(int value)
    {
        _diamondCount /= value;
        return _diamondCount;
    }

    public void DiamondAndKeyMultiplication(int value)
    {
        _diamondCount *= value;
        _totalDiamondCount += _diamondCount;
        ScoreText.text = "Score:" + _totalDiamondCount.ToString();
        _diamondCount = 0;
    }
}
