using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSuper
{
    protected Animator m_Anim;
    protected CharacterSuper m_Char_State;
    protected ConfigClass m_Config;
        
    public AnimationSuper()
    {

    }
    public virtual void PlayAnimation() // 애니매이션 플레이
    {
        PlayMove();
        PlayRun();
        PlayJump();
        PlayAttack();
    }
    public virtual void PlayMove() // 이동
    {
        m_Anim.SetFloat("H",m_Char_State.GetMoveH());
        m_Anim.SetFloat("V",m_Char_State.GetMoveV());
    }
    public virtual void PlayRun()//뛰기
    {
        if (m_Char_State.GetIsRun())
        {
            m_Anim.SetFloat("Speed", m_Char_State.GetSpeed());
        }
        else
        {
            m_Anim.SetFloat("Speed", m_Char_State.GetSpeed());
        }
    }
    public virtual void PlayJump() //점프
    {
        m_Anim.SetBool("Landing", false);
        m_Anim.SetBool("Landing_Move", false);
        if (m_Anim.GetCurrentAnimatorStateInfo(0).IsName("Base.Idle-Move"))
        {
            if (!m_Char_State.GetIsGroud())
            {
                m_Anim.SetBool("Falling", true);
            }
        }
        else if (m_Anim.GetCurrentAnimatorStateInfo(0).IsName("Base.Landing"))
        {
            if (m_Char_State.GetMoveH() == 0 && m_Char_State.GetMoveV() == 0)
            {
                m_Anim.SetBool("Landing", true);
            }
            else
            {
                m_Anim.SetBool("Landing_Move",true);
            }
        }
        else if(m_Anim.GetCurrentAnimatorStateInfo(0).IsName("Base.Falling"))
        {
            if (m_Char_State.GetIsGroud())
            {
                m_Anim.SetBool("Falling", false);
            }
        }
    }
    public virtual void PlayAttack()// 공격
    {
        if (m_Char_State.GetIsAttack())
        {
            m_Anim.SetBool("Is_Attack",true);
        }
        else
        {
            m_Anim.SetBool("Is_Attack", false);
        }
    }
    public virtual void PlayReload()// 재장전
    {

    }
    public virtual void SetChar(CharacterSuper CharScript) { m_Char_State = CharScript; }

    public virtual void SetAnimator( Animator anim) { m_Anim = anim; }

    ~AnimationSuper()
    {
        m_Anim = null;
    }
}
