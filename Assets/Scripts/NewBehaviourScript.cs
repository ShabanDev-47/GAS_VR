using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Git_Test m = new();
        print(m.Experience);
        m.Experience++;
        m.Experience++;
        print(m.Experience);

    }


}