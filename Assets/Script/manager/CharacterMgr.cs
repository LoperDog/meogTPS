﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMgr : MonoBehaviour
{
    public Camera mainCamera;

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
    [SerializeField]
    public GameMgr MyMgr;
    public Text Bullet_count;
    public Image Bullet_image;
    public Image HP_image;

    public enum Chacracter_Type
    {
        Dubu,
        Mandu
    };
    #region 캐릭터 정보
    [SerializeField]
    public float Char_Max_HP;
    [SerializeField]
    public float Char_Current_HP;

    [SerializeField]
    private int Player_ID;
    [SerializeField]
    private bool IsDead = false;

    [SerializeField]
    public int PlayerCode = 0;

    public float RAY_MaxDist = 500;

    #endregion
    #region 캐릭터 내부 스크립트 혹은 클래스
    // 필요한 기능등 붙이기
    [SerializeField]
    private Chacracter_Type Character_ID;

    [SerializeField]
    private AnimationSuper thisAnim;

    // 이 캐릭터가 실행할 스크립트
    private CharacterSuper thisCharacter;
    public float Current_Bullet;
    public float Max_Bullet;
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
    #region 캐릭터가 가지고 있는 자원 이팩트위치나 이팩트 혹은 총알 종류. 추후 수정
    public Transform[] Effect;
    public Transform[] Effectposition;

    public GameObject tempBullet;
    public GameObject FirePoint;
    #endregion
    // 캐릭터를 만들기 위해 아이디를 받는다.
    void Start()
    {
        // 캐릭터 받아오기 세팅
        Player_tr = GetComponent<Transform>();
        Player_rb = GetComponent<Rigidbody>();
        Camera_tr = Camera.main.GetComponent<Transform>();
        _networkView = GetComponent<NetworkView>();


        config = new ConfigClass();
        //Screen.lockCursor = true;
        // 캐릭터 생성
        switch (Character_ID)
        {
            case Chacracter_Type.Dubu:


                Char_Current_HP = config.DubuHP;
                Char_Max_HP = config.DubuHP;
                thisCharacter = new DubuCharacter();
                thisCharacter.SetBullet(config.DubuBullet);
                thisCharacter.SetMoveSpeed(config.DubuMoveSpeed);
                thisCharacter.SetRunSpeed(config.DubuRunSpeed);
                thisCharacter.SetJumpForce(config.DubuJumpForce);
                thisCharacter.SetReLoadTime(config.DubuReloadTime);
                FirePoint.transform.localPosition = config.DubuFirePosition;
                // 애니매이션 추후 수정
                thisAnim = new AnimationSuper();
                break;
            case Chacracter_Type.Mandu:


                Char_Current_HP = config.ManduHP;
                Char_Max_HP = config.ManduHP;
                thisCharacter = new ManduCharacter();
                thisCharacter.SetBullet(config.ManduBullet);
                thisCharacter.SetMoveSpeed(config.ManduMoveSpeed);
                thisCharacter.SetRunSpeed(config.ManduRunSpeed);
                thisCharacter.SetJumpForce(config.ManduJumpForce);
                thisCharacter.SetReLoadTime(config.ManduReloadTime);
                FirePoint.transform.localPosition = config.ManduFirePosition;
                // 애니매이션 추후 수정
                thisAnim = new AnimationSuper();
                break;
            default:

                break;
        }
        // 세팅
        thisCharacter.SetPlayerOb(gameObject);
        thisCharacter.SetCoroutine(gameObject.AddComponent<CoroutinClass>());
        thisAnim.SetChar(thisCharacter);
        thisAnim.SetAnimator(gameObject.GetComponent<Animator>());


        thisCharacter.SetPlayerTr(Player_tr);
        thisCharacter.SetPlayerRb(Player_rb);
        thisCharacter.SetCameraTr(Camera_tr);
        thisCharacter.SetFirePoint(FirePoint);

        thisCharacter.SetAttackSpeed(0.3f);
        thisCharacter.CreateBullet(config.DubuBullet, tempBullet);
        thisCharacter.SetBulletObject(tempBullet);

        // 임시
        thisCharacter.SetEffect(Effect);
        thisCharacter.SetEffectPosition(Effectposition);

        if (_networkView.isMine)
        {
            HP_image = GameObject.Find("Hp_Image").GetComponent<Image>();
            Bullet_count = GameObject.Find("Bullet_Count").GetComponent<Text>();
            Bullet_image = GameObject.Find("Bullet_Image").GetComponent<Image>();
            Camera.main.GetComponent<Cam>().SetPlayer(Player_tr);
            mainCamera = Camera.main;

        }
    }

    void Update()
    {
        //캐릭터 업데이트
        //thisCharacter.CharacterUpdate();

        //입력을 받고 저장한다.
        if (_networkView.isMine)
        {
            Show_UI();
            //InputControll();
            // 키를 적용해준다.
            //thisCharacter.SetCharacterMove(Key_H, Key_V);
            //InputControll();
            // 키를 적용해준다.
            //thisCharacter.SetCharacterMove(Key_H, Key_V);
        }
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
        }*/
        // 상태에 맞춰서 알아서 애니매이션 플레이
        //thisAnim.PlayAnimation();
        //Debug.DrawLine(FirePoint.transform.position, FirePoint.transform.position + (FirePoint.transform.forward * 10f), Color.cyan);
    }
    public Vector3 ShootTheFuckingRay()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f));
        if (Physics.Raycast(ray, out hit, RAY_MaxDist))
        {
            return hit.point;
            //FirePoint.transform.LookAt(hit.point);
        }
        else
        {
            return ray.origin + (Camera.main.transform.forward * 500f);
            //FirePoint.transform.LookAt(ray.origin + (Camera.main.transform.forward * 500f));
        }
    }
    public void Show_UI()
    {
        //총알
        Current_Bullet = thisCharacter.m_Current_Bullet;
        Max_Bullet = thisCharacter.m_Max_Bullet;
        Bullet_count.text = Current_Bullet + "/" + Max_Bullet + ToString();
        Bullet_image.fillAmount = Current_Bullet / Max_Bullet;
        //체력
        HP_image.fillAmount = Char_Current_HP/Char_Max_HP;
    }
    [RPC]
    public void SetFirePoint(Vector3 viewPoint)
    {
        FirePoint.transform.LookAt(viewPoint);
        thisCharacter.Attack();
    }
    [RPC]
    public void SetCharacterJump()
    {
        thisCharacter.Jump();
    }
    [RPC]
    public void SetCharacterReload()
    {
        thisCharacter.ReLoad();
    }
    [RPC]
    public void SetCharacterRollong()
    {
        thisCharacter.Rolling();
    }
    [RPC]
    public void GetDamage(float de)
    {
        Debug.Log("맞은 아이디 : " + _networkView.viewID + " 남은 채력 : " + Char_Current_HP);
        Char_Current_HP -= de;
    }
    // 강공격
    [RPC]
    public void SetCharacterStAttack()
    {
        thisCharacter.StrongAttack();
    }
    // 특수기
    [RPC]
    public void SetCharacterSPAttack()
    {
        thisCharacter.SpecialAttack();
    }
    public void ShotPlayer(NetworkView Player)
    {
        Player.RPC("GetDamage", RPCMode.AllBuffered, (float)config.DubuDamage);
    }
    void FixedUpdate()
    {
        if (Char_Current_HP <= 0)
        {
            thisCharacter.Is_Dead = true;
            thisAnim.PlayAnimation();
            return;
        }
        thisCharacter.CharacterUpdate();

        if (_networkView.isMine)
        {
            InputControll();
            thisCharacter.Turn();
        }
        thisCharacter.SetCharacterMove(Key_H, Key_V);
        thisAnim.PlayAnimation();
    }

    public void InputControll()
    {
        Key_H = Input.GetAxis("Horizontal");
        Key_V = Input.GetAxis("Vertical");
        //Click_Left = Input.GetMouseButton(0);
        if (Input.GetMouseButton(0))
        {
            _networkView.RPC("SetFirePoint", RPCMode.AllBuffered, ShootTheFuckingRay());
            // 네트워크 알피씨를 날려야 한다.
        }
        if (Input.GetMouseButton(1))
        {

        }
        if (Input.GetKey(KeyCode.Q))
        {

        }
        Click_Right = Input.GetMouseButton(1);
        Key_Shift = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        if (Key_Shift)
        {
            thisCharacter.SetRun(Key_Shift);
        }
        thisCharacter.SetRun(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift));
        if (Input.GetKey(KeyCode.Space))
        {
            //_networkView.RPC("SetCharacterJump", RPCMode.AllBuffered, null);
            thisCharacter.Jump();
        }
        if (Input.GetKey(KeyCode.F))
        {
            _networkView.RPC("SetCharacterRollong", RPCMode.AllBuffered, null);
        }
        if (Input.GetKey(KeyCode.R))
        {
            _networkView.RPC("SetCharacterReload", RPCMode.AllBuffered, null);
        }

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
    #region RPC함수
    // 플레이어의 타겟이 맞았을때
    [RPC]
    public void HitTheTarget(NetworkView temp)
    {

    }
    [RPC]
    public void KeyEvent()
    {

    }
    #endregion
    #region 네트워크 콜백
    void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
    {
        if (stream.isWriting)
        {
            // 임시 각자의 코드 값 세팅
            //int CharCode = MyMgr.GetPlayerCode();

            // 위치, 각도
            Vector3 pos = Player_tr.position;
            Quaternion rot = Player_tr.rotation;

            float H = Key_H;
            float V = Key_V;
            bool Shift = Key_Shift;

            // 키 동기화
            Key_Shift = thisCharacter.GetIsRun();

            // 임시로 캐릭터 번호 맞추기

            // 위치 전송
            stream.Serialize(ref pos);
            stream.Serialize(ref rot);

            // 키동기 -> 움직임등의 연속적인 것들만 동기화 시킨다.
            stream.Serialize(ref H);
            stream.Serialize(ref V);
            stream.Serialize(ref Shift);



        }
        else
        {
            // 임시 코드
            int CodeTemp = 0;

            Vector3 revPos = Vector3.zero;
            Quaternion revRot = Quaternion.identity;

            float recvh = 0.0f;
            float recvv = 0.0f;
            bool recvshift = false;

            // 캐릭터 코드 수신.
            //stream.Serialize(ref CodeTemp);

            // 데이터 수신
            stream.Serialize(ref revPos);
            stream.Serialize(ref revRot);

            // 이동키
            stream.Serialize(ref recvh);
            stream.Serialize(ref recvv);
            stream.Serialize(ref recvshift);

            // 플레이어 코드 업데이트
            //thisCharacter.SetPlayerCode(CodeTemp);

            Player_tr.position = revPos;
            Player_tr.rotation = revRot;
            Key_H = recvh;
            Key_V = recvv;
            thisCharacter.SetRun(recvshift);
        }
    }
    #endregion
}
