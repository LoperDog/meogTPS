using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInfoClass{
    private static MyInfoClass instance;

    public int MyCharNumb = 0;
    public int MyGameNumb = 0;
    public int PlayerLimit = 6;
    public NetworkMgr MyNetwork;
    
    public static MyInfoClass GetInstance()
    {
        if (instance == null)
        {
            instance = new MyInfoClass();
        }
        return instance;
    }
}
