using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagMediator : PureMVC.Patterns.Mediator
{
    public new static string NAME = "BagMediator";

    public BagView bagView;
     BagProxy bagProxy;
    public BagMediator(object obj):base(NAME)
    {
        //��ȡBagView
        bagView = ((GameObject)(obj)).GetComponent<BagView>();
       // bagProxy = Facade.RetrieveProxy(BagProxy.NAME) as BagProxy;
       // bagProxy.AddBagCell(bagView.bagitemcellparent);
       // bagProxy.AddBagItem();
       //����Ϣ�������
        SendNotification(BagFacade.CREATEBAG, bagView.bagitemcellparent);
    }
}
