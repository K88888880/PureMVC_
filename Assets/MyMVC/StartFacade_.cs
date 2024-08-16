using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFacade_ : PureMVC.Patterns.Facade
{
    public const string PLAY = "PLAY";
    public const string BUTSENDTIME = "BUTSENDTIME";
    public const string MODELSENDTIME = "MODELSENDTIME";





    /// <summary>
    /// µ¥Àý
    /// </summary>
    static StartFacade_()
    {
        m_instance = new StartFacade_();
    }
    public static StartFacade_ GetInstance()
    {
        return m_instance as StartFacade_;  
    }


    public void Start()
    {
        //Æô¶¯
        SendNotification(PLAY);
    }



    protected override void InitializeController()
    {
        base.InitializeController();
        RegisterCommand(PLAY,typeof(PanelCommand_));
        RegisterCommand(BUTSENDTIME, typeof(ModelCommand_));
    }

    protected override void InitializeModel()
    {
        base.InitializeModel();
        RegisterProxy(new PanelProxy_(PanelProxy_.NAME));
        
    }

    protected override void InitializeView()
    {
        base.InitializeView();

    }

}
