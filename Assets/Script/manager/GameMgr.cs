using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour {
    
    public int PlayerCode;
    public ConfigClass.GameState ThisGameState;
    public ConfigClass.GameState BeforeGameStete;

	void Start () {
        ThisGameState = ConfigClass.GameState.NoSession;
        BeforeGameStete = ConfigClass.GameState.NotStart;
	}
	
	// Update is called once per frame
	void Update () {
		if(this.ThisGameState != this.BeforeGameStete)
        {

            switch (this.BeforeGameStete)
            {
                case ConfigClass.GameState.NotStart:
                    break;

                case ConfigClass.GameState.NoSession:
                    break;

                case ConfigClass.GameState.InRoom:
                    break;

                case ConfigClass.GameState.InGame:
                    break;

                case ConfigClass.GameState.Matching:
                    break;

            }
        }
        switch (this.ThisGameState)
        {
            case ConfigClass.GameState.NoSession:
                break;

            case ConfigClass.GameState.InRoom:
                break;

            case ConfigClass.GameState.InGame:
                break;

            case ConfigClass.GameState.Matching:
                break;

        }
    }
    #region preProcess in GameState
    #endregion
    #region postProcess in GameState
    #endregion
    public void SetPlayerCode(int Code) { PlayerCode = Code; }
    public int GetPlayerCode() { return PlayerCode; }
}
