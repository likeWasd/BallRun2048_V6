using UnityEngine;

public class ObjectList : MonoBehaviour
{
    [SerializeField] GameObject diamondPrefab;
    [SerializeField] GameObject keyPrefab;
    GameObject cloneGate;
    [SerializeField] GameObject gatePack;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateObject(-2.5f, 30f, 3, DiamondGateScript.DiamondOperators.Add, true);
        GenerateObject(2.5f, 30f, 5, DiamondGateScript.DiamondOperators.Add, true);
        GenerateObject(-3.74f, 50f, 3, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(-1.7f, 50f, 3, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(1.44f, 50f, 4, DiamondGateScript.DiamondOperators.Multiply, true);
        GenerateObject(-2.52f, 70f, 2, DiamondGateScript.DiamondOperators.Divide, true);
        GenerateObject(-0.28f, 70f, 1, DiamondGateScript.DiamondOperators.Subtract, false);
        GenerateObject(-2.52f, 90f, 20, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(-0.62f, 90f, 30, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(4.06f, 90f, 50, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(-2.94f, 120f, 15, DiamondGateScript.DiamondOperators.Add, true);
        GenerateObject(1.8f, 120f, 20, DiamondGateScript.DiamondOperators.Add, true);
        GenerateObject(-0.56f, 120f, 4, DiamondGateScript.DiamondOperators.Divide, false);
        GenerateObject(3.91f, 120f, 10, DiamondGateScript.DiamondOperators.Multiply, false);
        for (int i = 0; i < 7; i++)
        {
            GenerateObject(-3.5f, 139f + i, 5, DiamondGateScript.DiamondOperators.Add, true);
            GenerateObject(3.5f, 139f + i, 3, DiamondGateScript.DiamondOperators.Add, false);
        }
        GenerateObject(-3.21f, 180f, 20, DiamondGateScript.DiamondOperators.Add, true);
        GenerateObject(3.64f, 180f, 3, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(1.53f, 180f, 30, DiamondGateScript.DiamondOperators.Add, true);
        GenerateObject(-0.83f, 180f, 3, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(-3.21f, 200f, 20, DiamondGateScript.DiamondOperators.Add, true);
        GenerateObject(0f, 200f, 5, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(3.53f, 200f, 15, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(-3.21f, 220f, 20, DiamondGateScript.DiamondOperators.Divide, true);
        GenerateObject(0f, 220f, 95, DiamondGateScript.DiamondOperators.Subtract, true);
        GenerateObject(3.53f, 220f, 5, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(-3.21f, 240f, 10, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(0f, 240f, 5, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(3.53f, 240f, 50, DiamondGateScript.DiamondOperators.Divide, false);
        GenerateObject(-3.21f, 260f, 100, DiamondGateScript.DiamondOperators.Divide, false);
        GenerateObject(0f, 260f, 1000, DiamondGateScript.DiamondOperators.Add, true);
        GenerateObject(3.53f, 260f, 20, DiamondGateScript.DiamondOperators.Subtract, false);
        GenerateObject(-3.21f, 280f, 44, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(0f, 280f, 100, DiamondGateScript.DiamondOperators.Divide, true);
        GenerateObject(3.53f, 280f, 44, DiamondGateScript.DiamondOperators.Multiply, false);
        for (int i = 0; i < 7; i++)
        {
            GenerateObject(-3.5f, 299f + i, 9, DiamondGateScript.DiamondOperators.Subtract, true);
            GenerateObject(3.5f, 299f + i, 15, DiamondGateScript.DiamondOperators.Subtract, false);
        }
        GenerateObject(-3f, 340f, 180, DiamondGateScript.DiamondOperators.Subtract, true);
        GenerateObject(0f, 340f, 600, DiamondGateScript.DiamondOperators.Add, true);
        GenerateObject(1.71f, 340f, 770, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(-3f, 360f, 2, DiamondGateScript.DiamondOperators.Multiply, true);
        GenerateObject(0f, 360f, 3, DiamondGateScript.DiamondOperators.Multiply, true);
        GenerateObject(1.71f, 360f, 98, DiamondGateScript.DiamondOperators.Divide, false);
        GenerateObject(-3.9f, 380f, 0, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(-1.5f, 380f, 0, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(0.9f, 380f, 0, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(2.1f, 380f, 0, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(-3.9f, 400f, 0, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(-1.5f, 400f, 0, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(0.9f, 400f, 0, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(4f, 400f, 0, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(-3.9f, 420f, 3, DiamondGateScript.DiamondOperators.Divide, true);
        GenerateObject(-1.5f, 420f, 3, DiamondGateScript.DiamondOperators.Divide, true);
        GenerateObject(0.9f, 420f, 3, DiamondGateScript.DiamondOperators.Divide, true);
        GenerateObject(3.7f, 420f, 1, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(-2.22f, 440f, 1, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(-0.42f, 440f, 1, DiamondGateScript.DiamondOperators.Subtract, false);
        GenerateObject(1.98f, 440f, 1, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(3.7f, 440f, 1, DiamondGateScript.DiamondOperators.Divide, false);
        for (int i = 0; i < 7; i++)
        {
            GenerateObject(-3.5f, 459f + i, 1, DiamondGateScript.DiamondOperators.Add, true);
            GenerateObject(3.5f, 459f + i, 1, DiamondGateScript.DiamondOperators.Subtract, false);
        }
        GenerateObject(-2.22f, 500f, 48, DiamondGateScript.DiamondOperators.Add, true);
        GenerateObject(-0.42f, 500f, 3, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(-3.11f, 520f, 60, DiamondGateScript.DiamondOperators.Divide, true);
        GenerateObject(-1.31f, 520f, 34, DiamondGateScript.DiamondOperators.Divide, false);
        GenerateObject(1.19f, 520f, 3, DiamondGateScript.DiamondOperators.Multiply, true);
        GenerateObject(2.9f, 520f, 12, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(-1.31f, 540f, 100, DiamondGateScript.DiamondOperators.Add, false);
        GenerateObject(1.19f, 540f, 40, DiamondGateScript.DiamondOperators.Subtract, true);
        GenerateObject(2.99f, 540f, 12, DiamondGateScript.DiamondOperators.Divide, false);
        GenerateObject(-4.09f, 560f, 2, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(-2.31f, 560f, 480, DiamondGateScript.DiamondOperators.Subtract, true);
        GenerateObject(-0.68f, 560f, 12, DiamondGateScript.DiamondOperators.Divide, false);
        GenerateObject(1.11f, 560f, 12, DiamondGateScript.DiamondOperators.Subtract, false);
        GenerateObject(3.91f, 560f, 86, DiamondGateScript.DiamondOperators.Add, true);
        GenerateObject(-2.59f, 580f, 0, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(-0.18f, 580f, 28, DiamondGateScript.DiamondOperators.Add, true);
        GenerateObject(2.66f, 580f, 0, DiamondGateScript.DiamondOperators.Multiply, true);
        GenerateObject(-2.59f, 600f, 1248, DiamondGateScript.DiamondOperators.Multiply, false);
        GenerateObject(-0.18f, 600f, 2369, DiamondGateScript.DiamondOperators.Multiply, true);
        GenerateObject(2.66f, 600f, 1, DiamondGateScript.DiamondOperators.Divide, false);
        for (int i = 0; i < 7; i++)
        {
            GenerateObject(-3.5f, 619f + i, 18, DiamondGateScript.DiamondOperators.Add, true);
            GenerateObject(3.5f, 619f + i, 16, DiamondGateScript.DiamondOperators.Divide, false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GenerateObject(float x, float z, float defaultChangingItem, DiamondGateScript.DiamondOperators op, bool isDiamond)
    {
        switch (isDiamond)
        {
            case true:
                cloneGate = Instantiate(diamondPrefab, new Vector3(x, 1, z), Quaternion.identity);
                cloneGate.transform.SetParent(gatePack.transform, false);
                DiamondGateScript diamondGateScript = cloneGate.GetComponent<DiamondGateScript>();
                diamondGateScript.Create((int)defaultChangingItem, op);
                break;
            default:
                cloneGate = Instantiate(keyPrefab, new Vector3(x, 1, z), Quaternion.identity);
                cloneGate.transform.SetParent(gatePack.transform, false);
                KeyGateScript keyGateScript = cloneGate.GetComponent<KeyGateScript>();
                keyGateScript.Create((int)defaultChangingItem, op);
                break;
        }
    }
}
