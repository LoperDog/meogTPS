using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSuper{
    
    // 공격 시작시간과 공격 
    protected float m_CurrentAtrack;
    protected float m_TimeAttack;

    protected bool IsAttack = false;

    protected int m_Current_Bullet = 0;
    protected int m_Max_Bullet = 0;

    public virtual void CharacterUpdate()
    {
        if (IsAttack)
        {
            m_CurrentAtrack += Time.deltaTime;
        }

    }
    // 생성자.
    public CharacterSuper()
    {
        m_CurrentAtrack = 0.0f;
        m_TimeAttack = 0.5f;

    }
    #region 캐릭터 기능 정의
    public virtual void Attack()
    {
        if(m_CurrentAtrack > m_TimeAttack && !IsAttack)
        {

        }
    }

    public virtual void Move()
    {
        Debug.Log("상속전 공격");
    }
    public virtual void ReLoad()
    {

    }
    #endregion 
    public virtual void SetBullet(int bulletMax)
    {
        m_Max_Bullet = bulletMax;
        m_Current_Bullet = bulletMax;
    }
    // 소멸
    ~CharacterSuper()
    {

    }
}
