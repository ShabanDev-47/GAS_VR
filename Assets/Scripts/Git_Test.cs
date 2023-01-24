using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Git_Test : MonoBehaviour
{
    private int experience = 5;
    public int Experience
    {
        get { return experience; }
        set { experience = value; }
    }
    public int Level
    {
        get { return experience/1000; }
        set { experience = value*1000; }    
    }

    // Start is called before the first frame update
    void Start()
    {
        print(Level);
    }


}
