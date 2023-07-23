using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSmapling : MonoBehaviour
{
    public Animator samplerAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(QRCodeManager.qrScanned)
        {
            samplerAnim.SetBool("Tree Growing", true);
        }
    }


    
}

