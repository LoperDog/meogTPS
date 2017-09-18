﻿using System.Collections;
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
        m_Anim.SetBool("S_A_End", false);
    }
    public void SetStrongAttackDash()
    {
        m_Anim.SetBool("Is_StrongAttackReady", false);
        m_Anim.SetBool("Is_StrongAttackDash", true);
    }
    public void SetStrongAttackEnd()
    {
        m_Anim.SetBool("S_A_End", true);
        m_Anim.SetBool("Is_StrongAttackDash", false);
        m_Anim.SetBool("Is_StrongAttackEnd", true);
    }
<<<<<<< HEAD
=======
    public void SetSpecialAttackReady()
    {

    }
    public void SetSpecialAttackDash()
    {

    }
    public void SetSpecialAttackEnd()
    {

    }
>>>>>>> 037a26b9c7a35f9d34f14e58e45eb02a770518b9
}

