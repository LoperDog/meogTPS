using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DubuAnimation : AnimationSuper
{
    DubuCharacter CharacterScript;
    public override void PlayAttack()
    {
        m_Anim.SetBool("Is_Attack", m_Char_State.GetIsAttack());
        m_Anim.SetBool("LeftAttack", CharacterScript.AttackIsLeft);
        m_Anim.SetBool("RightAttack", !CharacterScript.AttackIsLeft);
    }
    public override void SetChar(CharacterSuper CharScript)
    {
        base.SetChar(CharScript);
        CharacterScript = (DubuCharacter)CharScript;
    }
    public void SetStrongAttackReady()
    {
        m_Anim.SetBool("Is_StrongAttackReady", true);
        m_Anim.SetBool("Is_StrongAttackEnd", false);
        m_Anim.SetBool("Strong_A_End", false);
    }
    public void SetStrongAttackDash()
    {
        m_Anim.SetBool("Is_StrongAttackDash", true);
        m_Anim.SetBool("Is_StrongAttackReady", false);
    }
    public void SetStrongAttackEnd()
    {
        m_Anim.SetBool("Strong_A_End", true);
        m_Anim.SetBool("Is_StrongAttackDash", false);
        m_Anim.SetBool("Is_StrongAttackEnd", true);
    }
    public void SetSpecialAttackReady()
    {
        m_Anim.SetBool("Is_SpecialAttackReady", true);
    }
    public void SetSpecialAttackDash()
    {
        m_Anim.SetBool("Is_SpecialAttackReady", false);
        m_Anim.SetBool("Is_SpecialAttackDash", true);
    }
    public void SetSpecialAttackEnd()
    {
        m_Anim.SetBool("Is_SpecialAttackDash", false);
        m_Anim.SetBool("Is_SpecialAttackEnd", true);
        m_Anim.SetBool("Special_A_End", true);
    }
}

