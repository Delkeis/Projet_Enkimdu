using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUiController : MonoBehaviour
{
    private GameObject myInventoryUi;
    public bool InventoryIsVisible;
    // Start is called before the first frame update
    void Start()
    {
        myInventoryUi = GameObject.FindGameObjectWithTag("InventoryUiTag");
        InventoryIsVisible = false;
        myInventoryUi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) && InventoryIsVisible == false){
            InventoryIsVisible = true;
            myInventoryUi.SetActive(true);
            Debug.Log("inv on");
        }
        else if (Input.GetKeyDown(KeyCode.B) && InventoryIsVisible == true){
            InventoryIsVisible = false;
            myInventoryUi.SetActive(false);
            Debug.Log("inv off");
        }
    }
}
