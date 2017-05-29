using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSuper
{
    protected Animator m_Anim;
    protected CharacterSuper m_Char_State;
        
    public AnimationSuper()
    {

    }
    // 애니매이션 플레이
    public virtual void PlayAnimation()
    {
        PlayMove();
    }
    // 이동 애니매이션 정의
    public virtual void PlayMove()
    {
        m_Anim.SetFloat("H",m_Char_State.GetMoveH());
        m_Anim.SetFloat("V",m_Char_State.GetMoveV());

        if (m_Char_State.GetIsGroud() && Input.GetKeyDown(KeyCode.Space))//점프
        {
            m_Anim.SetTrigger("Jump_S");
        }
        else if(!m_Char_State.GetIsGroud())
        {
            m_Anim.SetTrigger("Jump_ing");
        }
    }
    // 공격 애니매이션 정의
    public virtual void PlayAttack()
    {

    }
    // 재장전 애니매이션 정의
    public virtual void PlayReload()
    {

    }
    public virtual void SetChar(CharacterSuper CharScript) { m_Char_State = CharScript; }

    public virtual void SetAnimator( Animator anim) { m_Anim = anim; }

    ~AnimationSuper()
    {
        m_Anim = null;
    }
}
