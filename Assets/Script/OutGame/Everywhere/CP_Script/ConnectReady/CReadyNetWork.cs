using System.Net.Sockets;
using ConstValueInfo;

public class CReadyNetWork
{
    private static CReadyNetWork mInstance;
    private TcpClient mClient;// = new TcpClient();
    private NetworkStream mStream;

    private CReadyNetWork()
    {
        //UnityEngine.Debug.Log("CReadyNetWork 생성자 호출1");
        mClient = new TcpClient();
        //UnityEngine.Debug.Log("CReadyNetWork 생성자 호출2" + ConstValue.IP + ConstValue.Port);
        mClient.Connect(ConstValue.IP, ConstValue.Port);
       // UnityEngine.Debug.Log("CReadyNetWork 생성자 호출3");
        mStream = mClient.GetStream();
    }
    ~CReadyNetWork()
    {
//        UnityEngine.Debug.Log("CReadyNetWork 소멸자 호출");
        mStream.Close();
        mClient.Close();
    }
    public static CReadyNetWork GetInstance()
    {
        if(null == mInstance)
        {
            mInstance = new CReadyNetWork();
        }
        return mInstance;
    }
    
    public bool IsConnected()
    {
        return mClient.Connected;
    }

    public NetworkStream GetStream()
    {
        return mStream;
    }

    public void CloseStream()
    {
 //       UnityEngine.Debug.Log("mStream Close() 호출");
        mStream.Close();
    }

    public void CloseClient()
    {
 //       UnityEngine.Debug.Log("mClient Close() 호출");
        mClient.Close();
    }

}

