using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIHandler : MonoBehaviour
{
    public TMP_Text text;
    public float gasMeter = 45;
    // Start is called before the first frame update
    void Start()
    {
        text.text = gasMeter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (gasMeter > 50f)
        {
            text.faceColor = Color.green;
            //TODO::::
        }
    }
}
