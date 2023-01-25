using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : Git_Test,Iprintable
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        //Git_Test m = 
        //    new Git_Test();
        //print(m.Experience);
        //m.Experience++;
        //m.Experience++;
        //print(m.Experience);
        Talk();
        printing();
    }

    public override void Talk()
    {
        base.Talk();
        print("I love you dad");
    }

    public void printing()
    {
        print("Shiiit");
    }


}
