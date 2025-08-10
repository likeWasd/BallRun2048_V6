using TMPro;
using UnityEngine;

public class ItemGateScript : MonoBehaviour
{
    /// <summary>
    /// ダイヤモンドの個数を変える値
    /// </summary>
    public int valueChangingItem;
    /// <summary>
    /// ダイヤモンドの個数をどうやって変化させるか
    /// </summary>
    public enum ItemOperators
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    public ItemOperators itemOperatorType;
    [SerializeField] private TextMeshProUGUI _tmpGateItemCount;

    public void Create(int defaultChangingItem, ItemOperators op)
    {
        valueChangingItem = defaultChangingItem;
        switch (itemOperatorType)
        {
            case ItemOperators.Add:
                _tmpGateItemCount.text = $"+{valueChangingItem}";
                break;
            case ItemOperators.Subtract:
                _tmpGateItemCount.text = $"-{valueChangingItem}";
                break;
            case ItemOperators.Multiply:
                _tmpGateItemCount.text = $"×{valueChangingItem}";
                break;
            case ItemOperators.Divide:
                _tmpGateItemCount.text = $"÷{valueChangingItem}";
                break;
        }
    }
}

public class Hoge
{
    public int Number => number;
    private int number;
    public void AddNumber(int value)
    {
        number = value;
    }
}

public class Fuga
{
    public Hoge hoge;
    public void XXTest()
    {
        hoge = new Hoge();
        hoge.AddNumber(100);
    }
}