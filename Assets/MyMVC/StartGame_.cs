using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame_ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartFacade_.GetInstance().Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
