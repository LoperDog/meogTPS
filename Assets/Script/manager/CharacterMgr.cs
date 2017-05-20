using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMgr : MonoBehaviour
{
    public enum Chacracter_Type
    {
        Dubu,
        Mandu
    };

    [SerializeField]
    private float Char_Max_HP;
    [SerializeField]
    private float Char_Current_HP;

    [SerializeField]
    private int Char_Max_Bullet;
    [SerializeField]
    private int Char_Current_Bullet;


    [SerializeField]
    private int Player_ID;

    [SerializeField]
    private Chacracter_Type Character_ID;

    [SerializeField]
    private UISuper thisUI;

    // 이 캐릭터가 실행할 스크립트
    private CharacterSuper thisCharacter;

    // 캐릭터를 만들기 위해 아이디를 받는다.
	void Start ()
    {
        // 캐릭터 생성
        switch (Character_ID)
        {
            case Chacracter_Type.Dubu:
                thisCharacter = new DubuCharacter();
                break;
            case Chacracter_Type.Mandu:
                thisCharacter = new ManduCharacter();
                break;

        }
	}
	
	void Update ()
    {
        thisCharacter.Attack();
	}
    public void SetCharID(Chacracter_Type Code) { Character_ID = Code; }
}
