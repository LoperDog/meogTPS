﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMgr : MonoBehaviour
{
    public GameObject tempBullet;

    [SerializeField]
    private ConfigClass config;

    private Transform Player_tr;
    private Rigidbody Player_rb;
    private Transform Camera_tr;

    private NetworkView _networkView;
    private Vector3 Char_Pos;
    private Quaternion Char_Rot;

    [SerializeField]
    List<GameObject> LoadChar;
    [SerializeField]
    public List<GameObject> LoadBullet;

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
    private float Key_H = 0.0f;             //키동기 필요
    private float Key_V = 0.0f;
    // 공격키
    private bool Click_Left = false;        // 개별동기
    private bool Click_Right = false;
    // 달리기 키
    private bool Key_Shift = false;         // 키동기 필요
    // 재장전
    private bool Key_R = false;             // 개별 동기
    private bool Key_Space = false;         // 개별 동기
    #endregion

    // 캐릭터를 만들기 위해 아이디를 받는다.
    void Start ()
    {
        // 캐릭터 받아오기 세팅
        Player_tr = GetComponent<Transform>();
        Player_rb = GetComponent<Rigidbody>();
        Camera_tr = Camera.main.GetComponent<Transform>();
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
        // 애니매이션 정의
        thisCharacter.SetPlayerOb(gameObject);
        thisCharacter.SetCoroutine(gameObject.AddComponent<CoroutinClass>());
        thisAnim.SetAnimator(gameObject.GetComponent<Animator>());

        thisCharacter.SetPlayerTr(Player_tr);
        thisCharacter.SetPlayerRb(Player_rb);
        thisCharacter.SetCameraTr(Camera_tr);
        // 나일때 할일
        //if (_networkView.isMine)
        //{

        //}
	}
	
	void Update ()
    {
        //캐릭터 업데이트
        thisCharacter.CharacterUpdate();

        //입력을 받고 저장한다.
        //if (_networkView.isMine)
        //{
            InputControll();
            // 키를 적용해준다.
            thisCharacter.SetCharacterMove(Key_H, Key_V);
        //}
        /*
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
        // 상태에 맞춰서 알아서 애니매이션 플레이
        thisAnim.PlayAnimation();
        }*/
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
    
    #region 네트워크 콜백
    void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
    {
        if (stream.isWriting)
        {
            // 위치, 각도
            Vector3 pos = Player_tr.position;
            Quaternion rot = Player_tr.rotation;

            // 키 동기화


            // 위치 전송
            stream.Serialize(ref pos);
            stream.Serialize(ref rot);

            // 키동기 -> 움직임등의 연속적인 것들만 동기화 시킨다.
            stream.Serialize(ref Key_H);
            stream.Serialize(ref Key_V);
            stream.Serialize(ref Key_Shift);



        }
        else
        {
            Vector3 revPos = Vector3.zero;
            Quaternion revRot = Quaternion.identity;

            float recvh = 0.0f;
            float recvv = 0.0f;
            bool recvshift = false;
            // 데이터 수신
            stream.Serialize(ref revPos);
            stream.Serialize(ref revRot);

            // 이동키
            stream.Serialize(ref recvh);
            stream.Serialize(ref recvv);
            stream.Serialize(ref recvshift);

            Player_tr.position = revPos;
            Player_tr.rotation = revRot;
            Key_H = recvh;
            Key_V = recvv;
            Key_Shift = recvshift;
        }
    }
    #endregion
}
