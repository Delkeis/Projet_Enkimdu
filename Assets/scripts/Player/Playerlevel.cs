using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerlevel : MonoBehaviour
{
    public static int Levels = 0;
    public int lvl = 1;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Levels = lvl;
    }

    public static int GetLevel()
    {
        return(Levels);
    }
}
