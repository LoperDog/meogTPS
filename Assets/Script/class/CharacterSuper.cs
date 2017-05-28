using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSuper{
    
    // 버프 아이템이나 종류
    public enum ItemCode
    {
        Buff_Attack,
        Buff_Speed,
        Buff_DotHill,
        Nuff_Attack,
        Nuff_Speed,
        Nuff_DotDemage
    };

    // 공격 시작시간과 공격 
    public float m_CurrentAtrack;
    public float m_TimeAttack;
    public float m_CurrentReload;
    public float m_TimeReload;

<<<<<<< HEAD
    public bool IsAttack = false;
    public bool IsReLoad = false;
=======
    protected bool IsAttack = false;
    protected bool IsReLoad = false;
    protected bool Is_Ground = true;
    protected bool Is_Jump;
>>>>>>> e796adeb35940fe6ceccdbe11870096783c48dd9

    protected int m_Current_Bullet = 0;
    protected int m_Max_Bullet = 0;

    protected float m_Move_Speed = 1.0f;

    //이동중임을 알아낸다.
    protected float m_Move_H = 0.0f;
    protected float m_Move_V = 0.0f;

    //회전
    protected float Min_X = -360.0f;
    protected float Max_X = 360.0f;
    protected float Sens_X = 100.0f;
    protected float Rotation_X = 0.0f;

    protected Transform Player_tr;
<<<<<<< HEAD
    protected GameObject Player_Object;
    protected List<GameObject> Bullet;
    protected CoroutinClass coroutine;
=======
    protected Rigidbody Player_rb;
    protected Transform Camera_tr;

    protected GameObject Bullet;
>>>>>>> e796adeb35940fe6ceccdbe11870096783c48dd9

    public virtual void CharacterUpdate()
    {
        Debug.Log(Is_Ground);
        //공격중이라면
        if (IsAttack)
        {
            m_CurrentAtrack += Time.deltaTime;
            // 만약 
            if(m_CurrentAtrack > m_TimeAttack)
            {
                IsAttack = false;
                m_CurrentAtrack = 0.0f;
            }
        }
        Check_Ground();
        Move();
        Jump();
    }
    // 생성자.
    public CharacterSuper()
    {
        m_CurrentAtrack = 0.0f;
        m_TimeAttack = 0.5f;
        m_CurrentReload = 0.0f;
        m_TimeReload = 1.0f;
    }
    #region 캐릭터 기능 정의
    public virtual void Attack()
    {
        // 공격중이 아닌데 공격 이 시작된다면 - 공격 가능
        if(m_CurrentAtrack > m_TimeAttack && !IsAttack && !IsReLoad && m_Current_Bullet >0)
        {
            //공격 시작 코드
            m_Current_Bullet--;
            ShotBullet();
        }
        // 공격이 시작될수 있는데 총알이 없다면 - 공격 불가 상태
        else if (m_CurrentAtrack > m_TimeAttack && !IsAttack && !IsReLoad && m_Current_Bullet == 0)
        {
            // 리로드 시작.
            IsReLoad = true;
            
        }
        // 
        else
        {
            m_CurrentAtrack = 0.0f;
        }
    }

    public virtual void Move()
    {/*
        Vector3 Move = (Vector3.forward * m_Move_V) + (Vector3.right * m_Move_H);
        Move = Move.normalized;
        Player_tr.transform.position = Player_tr.position + Move* m_Move_Speed * Time.deltaTime;*/

        Vector3 forward = Player_tr.TransformDirection(Vector3.forward);
        forward = forward.normalized;

        Vector3 right = new Vector3(forward.z, 0, -forward.x);
        Vector3 moveDirection = (m_Move_H * right) + (m_Move_V * forward);
        Player_tr.position = Player_tr.position + moveDirection * m_Move_Speed * Time.deltaTime;
        Rotation_X += Input.GetAxis("Mouse X") * Sens_X * Time.deltaTime;
        Player_tr.localEulerAngles = new Vector3(0, Rotation_X, 0);
    }
    public virtual void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Is_Ground)
        {
            Is_Jump = true;
        }

        if (Is_Jump)
        {
            Player_rb.AddForce(0, 300, 0);
            Is_Jump = false;
        }

    }
    public virtual void Check_Ground()
    {
        RaycastHit hit;
        Debug.DrawRay(Player_tr.position, Vector3.down * 0.05f, Color.red);
        if (Physics.Raycast(Player_tr.position, Vector3.down, out hit, 0.05f))
        {
            if (hit.collider.tag == "GROUND")
            {
                Is_Ground = true;
                return;
            }
        }
        Is_Ground = false;
    }
    public virtual void ReLoad()
    {
        Debug.Log("상속전 재장전");
    }
    // 총알을 발사한다.
    public virtual void ShotBullet()
    {
        Debug.Log("상속전 공격 -> 오브젝트를 생성시킨다.");
    }
    public virtual void StartReload()
    {
        Debug.Log("상속전 캐릭터 재장전 시작");
    }
    public virtual void EndReLoad()
    {
        Debug.Log("상속전 캐릭터 재장전 끝");
    }
    #endregion

    #region 캐릭터 기본 세팅
    public virtual void SetBullet(int bulletMax)
    {
        m_Max_Bullet = bulletMax;
        m_Current_Bullet = bulletMax;
    }
    public virtual void SetMoveSpeed(float moveSpeed)
    {
        m_Move_Speed = moveSpeed;
    }
<<<<<<< HEAD
    public virtual void SetPlayerTr(Transform player) { Player_tr = player; SetPlayerOb(); Debug.Log(Player_Object); SetCoroutine(); }
    public virtual void SetPlayerOb() { Player_Object = Player_tr.GetComponent<GameObject>(); }
    public virtual void SetCoroutine() { coroutine = Player_Object.AddComponent<CoroutinClass>(); coroutine.SetCharacterScript(this); }
=======
    public virtual void SetPlayerTr(Transform player) { Player_tr = player; }
    public virtual void SetCameraTr(Transform camera) { Camera_tr = camera; }
    public virtual void SetPlayerRb(Rigidbody rigidbody) { Player_rb = rigidbody; }
    public virtual void SetCharacterMove(float H, float V) {m_Move_H = H; m_Move_V = V;}
>>>>>>> e796adeb35940fe6ceccdbe11870096783c48dd9
    #endregion

    #region 아이템 영역
    protected virtual void SetItem(float time,ItemCode code,float val)
    {
        switch (code)
        {
            case ItemCode.Buff_Attack:

                break;
            case ItemCode.Buff_Speed:
                break;
            case ItemCode.Buff_DotHill:
                break;
            case ItemCode.Nuff_Attack:
                break;
            case ItemCode.Nuff_Speed:
                break;
            case ItemCode.Nuff_DotDemage:

                break;
            default:
                break;
        }
        coroutine.StartBuffSetting(time, code, val);
    }
    #endregion

    #region 캐릭터 상태값 가져오기
    public virtual bool GetAttackorReload() { return IsAttack || IsReLoad; }
    public virtual float GetMoveH() { return m_Move_H; }
    public virtual float GetMoveV() { return m_Move_V; }
    // 0 이라면 트루
    public virtual bool GetEmptyBullet() { return m_Current_Bullet == 0; }
    #endregion
    
    // 소멸
    ~CharacterSuper()
    {

    }
}
