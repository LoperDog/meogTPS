using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSuper : MonoBehaviour
{
    protected Animator m_Anim;
    protected CharacterSuper m_Char_State;
        
    public AnimationSuper()
    {
        m_Anim = GetComponent<Animator>();
    }
    // 이동 애니매이션 정의
    public virtual void PlayMove()
    {

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


    ~AnimationSuper()
    {
        m_Anim = null;
    }
}
