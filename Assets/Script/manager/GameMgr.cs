using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public int PlayerCode;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        	
	}

    public void SetPlayerCode(int Code) { PlayerCode = Code; }
    public int GetPlayerCode() { return PlayerCode; }
}
