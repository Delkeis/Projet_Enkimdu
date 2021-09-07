using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsSpecs : MonoBehaviour
{
    public static int itemLevel;
    public int myItemLevel;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        itemLevel = myItemLevel;
    }

    public static int GetItemLevel(){
        return (itemLevel);
    }
}
