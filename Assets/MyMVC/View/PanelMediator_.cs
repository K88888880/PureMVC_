using PureMVC.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMediator_ : PureMVC.Patterns.Mediator
{
    public new static string NAME = "PanelMediator_";


    PanelView_ panelView;
    public PanelMediator_(object obj) : base(NAME)
    {
        panelView = ((GameObject)(obj)).GetComponent<PanelView_>();
        panelView.button.onClick.AddListener(() =>
        {
            SendNotification(StartFacade_.BUTSENDTIME);
        });
    }


    public override IList<string> ListNotificationInterests()
    {
        IList<string> list = new List<string>();
        list.Add(StartFacade_.MODELSENDTIME);
        return list;    
    }


    public override void HandleNotification(INotification notification)
    {
        base.HandleNotification(notification);
        switch(notification.Name)
        {
            case StartFacade_.MODELSENDTIME:
                panelView.text.text=notification.Body.ToString();   
                break;
        }
    }

}
