using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketInteractions : MonoBehaviour
{
    [SerializeField]
    private bool pConnected = false;
    private float cd;
    public UIHandler m;
    private void Start()
    {
        m = FindObjectOfType<UIHandler>();
        cd = 10;
    }

   
    public void SocketEnterd()
    {
        pConnected = true;
        Debug.Log("Handle Entered;");
    }
    public void SocketExited()
    {
        pConnected = false;
        if ( cd < 1)
        {
            Debug.Log("Success");
        }
    }

    private void Update()
    {
        if(pConnected)
        {              
                if (cd > 0)
                {
                
                    cd -= Time.deltaTime;
                    float gasNumber =  Mathf.Ceil(m.gasMeter += Time.deltaTime);
                    m.text.text = gasNumber.ToString();                                 
                    m.text.text = gasNumber.ToString();                                 
                    Debug.Log(cd);
                }
                else
                {
                    return;
                }

        }

    }




}
