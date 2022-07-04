using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : GenericMonoSingleton<TankService>
{
    [SerializeField] TankView tankPrefab;

    void Start()
    {
        CreateTank();
    }

    public void CreateTank()
    {
        TankModel tankModel = new TankModel();
        TankController tankController = new TankController(tankModel, tankPrefab);
    }
   
}