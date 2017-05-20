using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMgr : MonoBehaviour {
    public enum ChacracterCode
    {
        Dubu,
        Mandu
    };
    [SerializeField]
    private float CharHPMax;
    [SerializeField]
    private float CharHPCurrent;

    [SerializeField]
    private int CharBulletMax;
    [SerializeField]
    private int CharBulletCurrent;


    [SerializeField]
    private int PlayerID;

    [SerializeField]
    private ChacracterCode CharacterID;

    [SerializeField]
    private UISuper thisUI;

    // 이 캐릭터가 실행할 스크립트
    private CharacterSuper thisCharacter;

    // 캐릭터를 만들기 위해 아이디를 받는다.
	void Start () {
        // 캐릭터 생성
        switch (CharacterID)
        {
            case ChacracterCode.Dubu:
                thisCharacter = new DubuCharacter();
                break;
            case ChacracterCode.Mandu:
                thisCharacter = new ManduCharacter();
                break;

        }
	}
	
	void Update () {
        thisCharacter.Attack();
	}
    public void SetCharID(ChacracterCode Code) { CharacterID = Code; }
}
