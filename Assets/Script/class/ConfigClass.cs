using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigClass {
    #region 게임전체에 쓰일 부분
    public enum GameState
    {
        NoSession,
        Matching,
        InRoom,
        InGame,
        NotStart,
    };

    #endregion
    public Dictionary<string, float> ManduStatus = new Dictionary<string, float>();
    public Dictionary<string, float> DubuStatus = new Dictionary<string, float>();
    public Dictionary<string, Dictionary<string,float>> StatusConfigs = new Dictionary<string, Dictionary<string, float>>();
    public Dictionary<string, Vector3> ManduPosition = new Dictionary<string, Vector3>();
    public Dictionary<string, Vector3> DubuPosition = new Dictionary<string, Vector3>();
    public Dictionary<string, Dictionary<string, Vector3>> PositionConfig = new Dictionary<string, Dictionary<string, Vector3>>();

    public string ManduString = "Mandu";
    public string DubuString = "Dubu";
    
    public ConfigClass()
    {
        #region 만두콘피그
        ManduStatus["HP"] = 150f;

        ManduStatus["MoveSpeed"] = 2.0f;
        ManduStatus["RunSpeed"] = 6.8f;
        ManduStatus["JumpForce"] = 1500f;

        ManduStatus.Add("Cartridge" , 10f);
        ManduStatus.Add("ReLoadTime" , 2.0f);

        ManduStatus.Add("Attack" , 50f);
        ManduStatus.Add("AtttackSpeed" , 2.0f);

        ManduStatus.Add("StrongAttack" , 100f);
        ManduStatus.Add("StrongAttackSpeed" , 2.0f);

        ManduStatus.Add("SpecialAttack" , 0.0f);
        ManduStatus.Add("SpecialAttackSpeed" , 3.0f);

        ManduPosition.Add("FirePosition", new Vector3(0.0f, 1.15f, 0.8f));
        #endregion

        #region 두부콘피그
        DubuStatus["HP"] = 100f;

        DubuStatus["MoveSpeed"] = 2.8f;
        DubuStatus["RunSpeed"] = 7.5f;
        DubuStatus["JumpForce"] = 1500;
        // 장탄수
        DubuStatus["Cartridge"] = 50f;
        DubuStatus["ReLoadTime"] = 1.7f;

        DubuStatus["Attack"] = 15f;
        DubuStatus["AtttackSpeed"] = 0.25f;

        DubuStatus["StrongAttack"] = 30f;
        DubuStatus["StrongAttackSpeed"] = 5.0f;
        DubuStatus.Add("StongAttackReady", 0.23f);
        DubuStatus.Add("StongAttackTime", 0.43f);
        DubuStatus.Add("StongAttackEnd", 0.86f);

        DubuStatus["SpecialAttack"] = 100.0f;
        DubuStatus["SpecialAttackSpeed"] = 25.0f;
        DubuStatus.Add("SpecialAttackReady", 0.86f);
        DubuStatus.Add("SpecialAttackTime", 1.43f);
        DubuStatus.Add("SpecialAttackEnd", 1.43f);

        // 필요 포지션
        DubuPosition["FirePosition"] = new Vector3(0.0f, 1.15f, 0.8f);
        #endregion

        // 콘피그 적용. 
        StatusConfigs.Add(ManduString, ManduStatus);
        StatusConfigs.Add(DubuString, DubuStatus);
        PositionConfig.Add(ManduString, ManduPosition);
        PositionConfig.Add(DubuString, DubuPosition);
    }
}
