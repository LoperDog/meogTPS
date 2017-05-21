using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSuper{
    
    // 공격 시작시간과 공격 
    protected float m_CurrentAtrack;
    protected float m_TimeAttack;
    protected float m_CurrentReload;
    protected float m_TimeReload;

    protected bool IsAttack = false;
    protected bool IsReLoad = false;

    protected int m_Current_Bullet = 0;
    protected int m_Max_Bullet = 0;

    protected float m_Move_Speed = 1.0f;

    //이동중임을 알아낸다.
    protected float m_Move_H = 0.0f;
    protected float m_Move_V = 0.0f;


    protected Transform Player_tr;
    protected GameObject Bullet;
    public virtual void CharacterUpdate()
    {
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
        // 공격중이 아닌데 공격 이 시작된다면
        if(m_CurrentAtrack > m_TimeAttack && !IsAttack && !IsReLoad && m_Current_Bullet >0)
        {
            //공격 시작 코드
            m_Current_Bullet--;
            ShotBullet();
        }
        // 공격이 시작될수 있는데 총알이 없다면
        else if (m_CurrentAtrack > m_TimeAttack && !IsAttack && !IsReLoad && m_Current_Bullet == 0)
        {
            // 리로드 시작.
            IsReLoad = true;
            
        }
        // 
        else
        {
            IsAttack = false;
            m_CurrentAtrack = 0.0f;
        }
    }

    public virtual void Move()
    {
        Debug.Log("상속전 이동");
    }
    public virtual void ReLoad()
    {

    }
    // 총알을 발사한다.
    public virtual void ShotBullet()
    {

    }
    public virtual void StartReload()
    {

    }
    public virtual void EndReLoad()
    {

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
    public virtual void SetPlayerTr(Transform player) { Player_tr = player}
    #endregion
    #region 캐릭터 상태값 가져오기
    public virtual bool GetAttackorReload() { return IsAttack || IsReLoad; }
    public virtual float GetMoveH() { return m_Move_H; }
    public virtual float GetMoveV() { return m_Move_V; }
    // 0 이라면 트루
    public virtual bool GetEmptyBullet() { return m_Current_Bullet == 0; }
    public virtual void SetCharacterMove(float H,float V) { m_Move_H = H; m_Move_V = V; }
    #endregion
    // 소멸
    ~CharacterSuper()
    {

    }
}
