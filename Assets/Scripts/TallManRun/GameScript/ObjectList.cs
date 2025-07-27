using UnityEngine;

public class ObjectList : MonoBehaviour
{
    [SerializeField] GameObject diamondPrefab;
    [SerializeField] GameObject keyPrefab;
    GameObject cloneGate;
    [SerializeField] GameObject gatePack;
    enum op
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
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
        GenerateObject(-3.21f, 180f, 20, op.Add, true);
        GenerateObject(3.64f, 180f, 3, op.Multiply, true);
        GenerateObject(1.53f, 180f, 30, op.Add, true);
        GenerateObject(-0.83f, 180f, 3, op.Add, true);
        GenerateObject(-3.21f, 200f, 20, op.Add, true);
        GenerateObject(0f, 139f, 5, op.Add, true);
        GenerateObject(3.53f, 200f, 15, op.Add, true);
        GenerateObject(-3.21f, 220f, 20, op.Divide, true);
        GenerateObject(0f, 220f, 95, op.Subtract, true);
        GenerateObject(3.53f, 220f, 5, op.Multiply, true);
        GenerateObject(-3.21f, 240f, 10, op.Multiply, true);
        GenerateObject(0f, 240f, 5, op.Add, true);
        GenerateObject(3.53f, 240f, 50, op.Divide, true);
        GenerateObject(-3.21f, 260f, 100, op.Divide, true);
        GenerateObject(0f, 260f, 1000, op.Add, true);
        GenerateObject(3.53f, 260f, 20, op.Subtract, true);
        GenerateObject(-3.21f, 280f, 44, op.Add, true);
        GenerateObject(0f, 280f, 100, op.Divide, true);
        GenerateObject(3.53f, 280f, 44, op.Multiply, true);
        GenerateObject(-3f, 340f, 180, op.Subtract, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
        GenerateObject(-3.5f, 139f, 5, op.Add, true);
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
