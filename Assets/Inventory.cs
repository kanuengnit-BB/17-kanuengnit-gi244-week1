using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Array
    private string[] intventoryArray = new []{"Sword","Shield","Potion"};
    
    //how to move element array => list
    private List<string> inventoryList;

    // Start is called before the first frame update
    void Start()
    {
        inventoryList = new List<string>(intventoryArray);
        DisplayInventory();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            inventoryList.Add("Helmet");
            DisplayInventory();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            inventoryList.Remove("Sword");
            DisplayInventory();
        }
    }

    void DisplayInventory()
    {
        int i=0;
        Debug.Log("Inventory:");
        foreach (var item in inventoryList)
        {
            Debug.Log($"{++i}. {item}");
            
        }
    }
    
    
}

