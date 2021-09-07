using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    private int itemLevel;
    // Start is called before the first frame update
    void Start()
    {
        itemLevel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Item Level : "+itemLevel);
    }

    public void SetItemLevel(int Level){
        Debug.Log("Item Level as set to lvl "+Level);
        itemLevel = Level;
    }
}
