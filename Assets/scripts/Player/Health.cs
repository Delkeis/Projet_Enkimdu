using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private int Points = 0;
    private int Pv = 100;
    //private Playerlevel playerlevel = GetComponent<Playerlevel>();
    private int tmp;
    private int Fpv;
    public Text pvText;
    public int PointPerLevels = 3;
    public int PointValue = 5;
    // Start is called before the first frame update
    void Start()
    {
        //pvText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Points = PointPerLevels * Playerlevel.GetLevel();
        tmp = Pv + Points * PointValue;
        pvText.text = "PV " + tmp;
    }

    public void ApplyDammage(float dmg)
    {
        Pv = Pv - (int)dmg;
    }

    public int getLife(){
        Fpv = Pv + Points * PointValue;
        return(Fpv);
    }
    //public static implicit operator Integer( Int32 x ) { return new Integer( x ); }
    //public static implicit operator Int32( Integer x ) { return x.Value; }
}