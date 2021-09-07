using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsController : MonoBehaviour
{
    private GameObject  myObjectCollide;
    private InventoryController  mobj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(ItemsSpecs.GetItemLevel());
    }

    void    OnTriggerEnter(Collider collision){
        if (collision.gameObject.tag == "Player"){
            foreach(Transform child in collision.gameObject.transform){

                if (child.tag == "HudTag"){
                    foreach (Transform subChild in child)
                    {
                        if (subChild.tag == "InventoryUiTag"){
                            subChild.GetComponent<InventoryController>().SetItemLevel(ItemsSpecs.GetItemLevel());
                        }        
                    }
                }
            }
            Destroy(this.gameObject);
        }
    }
}
