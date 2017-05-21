using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMgr : MonoBehaviour
{
    [SerializeField]
    private ConfigClass config;

    private Transform Player_tr;

    private NetworkView _networkView;
    private Vector3 Char_Pos;
    private Quaternion Char_Rot;

    [SerializeField]
    List<GameObject> LoadChar;

    public enum Chacracter_Type
    {
        Dubu,
        Mandu
    };
    #region 캐릭터 정보
    [SerializeField]
    private float Char_Max_HP;
    [SerializeField]
    private float Char_Current_HP;

    [SerializeField]
    private int Player_ID;
    [SerializeField]
    private bool IsDead = false;

    #endregion
    #region 캐릭터 내부 스크립트 혹은 클래스
    // 필요한 기능등 붙이기
    [SerializeField]
    private Chacracter_Type Character_ID;

    [SerializeField]
    private UISuper thisUI;

    [SerializeField]
    private AnimationSuper thisAnim;


    // 이 캐릭터가 실행할 스크립트
    private CharacterSuper thisCharacter;
    #endregion
    #region 캐릭터키값
    // 이동키
    private float Key_H = 0.0f;
    private float Key_V = 0.0f;
    // 공격키
    private bool Click_Left = false;
    private bool Click_Right = false;
    // 달리기 키
    private bool Key_Shift = false;
    // 재장전
    private bool Key_R = false;
    private bool Key_Space = false;
    #endregion

    // 캐릭터를 만들기 위해 아이디를 받는다.
    void Start ()
    {
        // 캐릭터 받아오기 세팅
        Player_tr = GetComponent<Transform>();
        _networkView = GetComponent<NetworkView>();


        config = new ConfigClass();
        // 캐릭터 생성
        switch (Character_ID)
        {
            case Chacracter_Type.Dubu:
                Char_Current_HP =       config.DubuHP;
                Char_Max_HP =           config.DubuHP;
                thisCharacter = new DubuCharacter();
                thisCharacter.SetBullet(config.DubuBullet);
                thisCharacter.SetMoveSpeed(config.DubuAttackSpeed);
                // 애니매이션 추후 수정
                thisAnim = new AnimationSuper();
                break;
            case Chacracter_Type.Mandu:
                Char_Current_HP =       config.ManduHP;
                Char_Max_HP =           config.ManduHP;
                thisCharacter = new ManduCharacter();
                thisCharacter.SetBullet(config.ManduBullet);
                thisCharacter.SetMoveSpeed(config.ManduMoveSpeed);
                // 애니매이션 추후 수정
                thisAnim = new AnimationSuper();
                break;
            default:

                break;
        }
        // 나일때 할일
        if (_networkView.isMine)
        {

        }
	}
	
	void Update ()
    {
        //캐릭터 업데이트
        thisCharacter.CharacterUpdate();

        //입력을 받고 저장한다.
        if (_networkView.isMine)
        {
            InputControll();
            // 키를 적용해준다.
            thisCharacter.SetCharacterMove(Key_H, Key_V);
        }
        else
        {
            if (Vector3.Distance(Player_tr.position, Char_Pos) >= 2.0f)
            {
                Player_tr.position = Char_Pos;
                Player_tr.rotation = Char_Rot;
            }
            else
            {
                // 전송받아온 변경된 위치로 부드럽게 이동
                Player_tr.position = Vector3.Lerp(Player_tr.position, Char_Pos, Time.deltaTime * 10.0f);
                // 전송받아온 변경된 각도로 부드럽게 회전
                Player_tr.rotation = Quaternion.Slerp(Player_tr.rotation, Char_Rot, Time.deltaTime * 10.0f);

            }
        }
	}

    public void InputControll()
    {
        Key_H = Input.GetAxis("Horizontal");
        Key_V = Input.GetAxis("Vertical");
        Click_Left = Input.GetMouseButton(0);
        Click_Right = Input.GetMouseButton(1);
        Key_Shift = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        Key_R = Input.GetKey(KeyCode.R);
        Key_Space = Input.GetKey(KeyCode.Space);
    }
    public void PlayAnimation()
    {
        // 이동 애니매이션
        thisAnim.PlayMove();
        // 공격 애니매이션

        // 재장전 애니매이션
    }

    public void SetCharID(Chacracter_Type Code) { Character_ID = Code; }
}
