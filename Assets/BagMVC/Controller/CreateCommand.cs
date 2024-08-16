using PureMVC.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCommand : PureMVC.Patterns.SimpleCommand
{
    //命令层调用model方法初始化背包
    public override void Execute(INotification notification)
    {
        Debug.Log(notification.Body);
        base.Execute(notification);
        BagProxy bagProxy=Facade.RetrieveProxy(BagProxy.NAME) as BagProxy;  
        //创建背包格子
        if (bagProxy != null)
        {
            switch(notification.Name)
            {
                case BagFacade.CREATEBAG:
                   
                    bagProxy.AddBagCell(notification.Body as Transform);
                    bagProxy.AddBagItem();
                    break;
            }
        }

    }
}
