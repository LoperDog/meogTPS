﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ConstValueInfo;
using System.Text;

public class Front : MonoBehaviour {

    CSender mSender;
    CListener mListener;

    GameObject mInputID;
    GameObject mInputPW;
    GameObject mInputGuestID;
    InputField mInputIDComponent; // ID 입력 창 컴포넌트
    InputField mInputPWComponent; // PW 입력 창 컴포넌트
    InputField mInputGuestIDComponent;
    

    // Use this for initialization
    void Awake () {
        mSender = CSender.GetInstance();
        mListener = CListener.GetInstance();
        mInputID = GameObject.FindGameObjectWithTag("InputIDTag");
        mInputPW = GameObject.FindGameObjectWithTag("InputPWTag");
        mInputGuestID = GameObject.FindGameObjectWithTag("TagInputGuestID");
        mInputIDComponent = mInputID.GetComponent<InputField>();
        mInputIDComponent.characterLimit = ConstValue.CharacterLimitID;
        mInputIDComponent.text = "";
        mInputPWComponent = mInputPW.GetComponent<InputField>();
        mInputPWComponent.text = "";
        mInputPWComponent.characterLimit = ConstValue.CharacterLimitPW;
        mInputGuestIDComponent = mInputGuestID.GetComponent<InputField>();
        mInputGuestIDComponent.text = "";
        mInputGuestIDComponent.characterLimit = ConstValue.CharacterLimitGuestName;
    }
	
	// Update is called once per frame
	void Update () {
    }

    public void SendID_PW()
    {
        string id = mInputIDComponent.text;
        string pw = mInputPWComponent.text;

        if ((id != null && id != "") && (pw != null && pw != ""))
        {
            id = id.Replace(" ", "");
            pw = pw.Replace(" ", "");
            string idpw = id + '/' + pw;
            //          Debug.Log("idpw = " + idpw);
            DataPacketInfo dataIDPWString = new DataPacketInfo((int)ProtocolInfo.ServerCommend, (int)ProtocolDetail.FrontMenu, (int)ProtocolFrontMenuTag.LoginMenu, idpw);
            mSender.Sendn(ref dataIDPWString);
            mInputPWComponent.text = "";
        }
        else
        {
 //           Debug.Log("아이디 혹은 비밀번호를 입력해 주세요.");
        }
    }

    public void SelectLoginButton()
    {
        CheckState.ChangeState(State.ClientLogin);
    }

    public void SelectBackButton()
    {
        CheckState.ChangeState(State.ClientFrontMenu);
    }

    public void SelectGuestLoginButton()
    {
        //DataPacketInfo dataGuestLogin = new DataPacketInfo((int)ProtocolInfo.ServerCommend, (int)ProtocolDetail.FrontMenu, (int)ProtocolFrontMenuTag.GuestMenu, null);
        //mSender.Sendn(ref dataGuestLogin);
        CheckState.ChangeState(State.ClientGuest);
    }

    public void SendGuestID()
    {
        string id = mInputGuestIDComponent.text;
        if (id != null && id != "")
        {
            id = id.Replace(" ", "");
            mInputIDComponent.text = id;
            DataPacketInfo dataIDPWString = new DataPacketInfo((int)ProtocolInfo.ServerCommend, (int)ProtocolDetail.FrontMenu, (int)ProtocolFrontMenuTag.GuestMenu, id);
            mSender.Sendn(ref dataIDPWString);
            mInputGuestIDComponent.text = "";
        }
    }
}
