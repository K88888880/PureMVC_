using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagFacade : PureMVC.Patterns.Facade
{
    public const string PLAYBAG = "PLAYBAG";
    public const string CREATEBAG = "CREATEBAG";




    /// <summary>
    /// ��̬��ʼ��
    /// </summary>
    static BagFacade()
    {
        m_instance = new BagFacade();
    }
    /// <summary>
    /// ��ȡ����
    /// </summary>
    /// <returns></returns>
    public static BagFacade GetInstance()
    {
        return m_instance as BagFacade; 
    }


    public void Start()
    {
        SendNotification(PLAYBAG);
    }

    /// <summary>
    /// ע������
    /// </summary>
    protected override void InitializeController()
    {
        base.InitializeController();
        RegisterCommand(PLAYBAG, typeof(BagCommand));
        RegisterCommand(CREATEBAG, typeof(CreateCommand));
    }
    /// <summary>
    /// ע��Model
    /// </summary>
    protected override void InitializeModel()
    {
        base.InitializeModel();
        RegisterProxy(new BagProxy(BagProxy.NAME));
    }


    protected override void InitializeView()
    {
        base.InitializeView();
    }
}
