using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class CharacterMgr : MonoBehaviour
{
=======
public class CharacterMgr : MonoBehaviour {
    [SerializeField]
    private ConfigClass config;
    
>>>>>>> 344abec1adddcec408cbb36bd306df2594b6791f
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
    private float Char_Move_Speed;

    [SerializeField]
    private int Player_ID;

    // 필요한 기능등 붙이기
    [SerializeField]
    private Chacracter_Type Character_ID;

    [SerializeField]
    private UISuper thisUI;

    [SerializeField]
    private AnimationSuper thisAnim;


    // 이 캐릭터가 실행할 스크립트
    private CharacterSuper thisCharacter;

    // 캐릭터를 만들기 위해 아이디를 받는다.
<<<<<<< HEAD
	void Start ()
    {
=======
	void Start () {
        config = new ConfigClass();
>>>>>>> 344abec1adddcec408cbb36bd306df2594b6791f
        // 캐릭터 생성
        switch (Character_ID)
        {
            case Chacracter_Type.Dubu:
                Char_Current_HP =       config.DubuHP;
                Char_Max_HP =           config.DubuHP;
                Char_Max_Bullet =       config.DubuBullet;
                Char_Current_Bullet =   config.DubuBullet;
                thisCharacter = new DubuCharacter();
                break;
            case Chacracter_Type.Mandu:
                Char_Current_HP =       config.ManduHP;
                Char_Max_HP =           config.ManduHP;
                Char_Max_Bullet =       config.ManduBullet;
                Char_Current_Bullet =   config.ManduBullet;
                thisCharacter = new ManduCharacter();
                break;
            default:

                break;
        }
	}
	
<<<<<<< HEAD
	void Update ()
    {
        thisCharacter.Attack();
=======
	void Update () {
        //캐릭터 업데이트
        thisCharacter.CharacterUpdate();

>>>>>>> 344abec1adddcec408cbb36bd306df2594b6791f
	}
    public void Key_H(float H)
    {

    }
    public void Key_V(float V)
    {

    }
    public void SetCharID(Chacracter_Type Code) { Character_ID = Code; }
}
