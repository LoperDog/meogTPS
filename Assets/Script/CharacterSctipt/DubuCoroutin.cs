﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DubuCoroutin : CoroutinClass
{
    public DubuCharacter DubuChar;
    public override void SetCharacterScript(CharacterSuper CharacterClass)
    {
        base.SetCharacterScript(CharacterClass);
        DubuChar = (DubuCharacter)CharacterClass;
    }

    public override void StartStrongAttckSetting()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.StrongAttackCoolTime = config.StatusConfigs["Dubu"]["StrongAttackSpeed"];
        base.StartStrongAttckSetting();
    }
    public override void StartSpecialAttack()
    {

        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.SpecialAttackCoolTime = config.StatusConfigs["Dubu"]["SpecialAttackSpeed"];
        base.StartSpecialAttack();
    }
    // 강공격을 시작한다.
    // 제어불가 상태가 되며 쿨타임이 시작되고
    public override IEnumerator SetStrongAttack()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;
        StartCoroutine(SetStrongAttackReady());
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StrongAttackSpeed"]);
        thisCharacterScript.IsStrongAttack = false;
    }
    public IEnumerator SetStrongAttackReady()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.StrongAttackReady();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StongAttackReady"]);
        StartCoroutine(SetStrongAttackDash());
    }
    public IEnumerator SetStrongAttackDash()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.StrongAttackDash();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StongAttackTime"]);
        StartCoroutine(SetStrongAttackEnd());
    }
    public IEnumerator SetStrongAttackEnd()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.StrongAttackEnd();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StongAttackEnd"]);
        thisCharacterScript.CanControll = true;
    }

    //특수기
    public override IEnumerator SetSpecialAttack()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        Debug.Log("두부 코루틴");
        //StartCoroutine(SetSpecialSpecialAttakReady());
        DubuChar.SpecialAttack();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackSpeed"]);
    }
    public IEnumerator SetSpecialSpecialAttakReady()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackSpeed"]);
    }
}
