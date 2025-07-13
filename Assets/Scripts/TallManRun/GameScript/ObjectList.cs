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
        GenerateObject(1.44f, 50f, 4, DiamondGateScript.DiamondOperators.Multiply, true);
        GenerateObject(-2.52f, 70f, 2, DiamondGateScript.DiamondOperators.Divide, true);
        GenerateObject(-2.94f, 120f, 15, DiamondGateScript.DiamondOperators.Add, true);
        GenerateObject(1.8f, 120f, 20, DiamondGateScript.DiamondOperators.Add, true);
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
