using System.Collections;
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

    //강공격
    public override void StartStrongAttckSetting()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.StrongAttackCoolTime = config.StatusConfigs["Dubu"]["StrongAttack_CoolTime"];
        base.StartStrongAttckSetting();
    }
    public override IEnumerator SetStrongAttack()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;
        StartCoroutine(SetStrongAttackReady());
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StrongAttack_CoolTime"]);
        thisCharacterScript.IsStrongAttack = false;
    }
    public IEnumerator SetStrongAttackReady()
    {
        if (config == null)
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
        thisMgr.m_StrongAttack.ReSetAttack();
        StartCoroutine(SetStrongAttackEnd());
        thisCharacterScript.CanControll = true;
    }
    public IEnumerator SetStrongAttackEnd()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.StrongAttackEnd();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["StongAttackEnd"]);
    }
    //특수기
    public override void StartSpecialAttackSetting()
    {

        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.SpecialAttackCoolTime = config.StatusConfigs["Dubu"]["SpecialAttack_CoolTime"];
        base.StartSpecialAttackSetting();
    }
    public override IEnumerator SetSpecialAttack()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisCharacterScript.CanControll = false;
        StartCoroutine(SetSpecialSpecialAttakReady());
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttack_CoolTime"]);
        thisCharacterScript.IsSpecialAttack = false;
    }
    public IEnumerator SetSpecialSpecialAttakReady()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.SpecialAttackReady();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackReady"]);
        StartCoroutine(SetSpecialAttackDash());
    }
    public IEnumerator SetSpecialAttackDash()
    {
        if(config == null)
        {
            config = new ConfigClass();
        }
        DubuChar.SpecialAttackDash();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackTime"]);
        StartCoroutine(SetSpecialAttackEnd());
    }
    public IEnumerator SetSpecialAttackEnd()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.m_SpecialAttack.ReSetAttack();
        DubuChar.SpecialAttackEnd();
        yield return new WaitForSeconds(config.StatusConfigs["Dubu"]["SpecialAttackEnd"]);
        thisCharacterScript.CanControll = true;
    }
}
