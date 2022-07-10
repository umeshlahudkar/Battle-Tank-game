using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletService : GenericMonoSingleton<BulletService>
{
    public BulletListScriptableObject bulletList;

    public void SpwanBullet(BulletType bulletType, Transform bulleteTransform)
    {
        BulletScriptableObject bulletScriptableObject = GetBulletScriptablObject(bulletType);
        BulletModel bulletModel = new BulletModel(bulletScriptableObject.speed);
        BulletController bulletController = new BulletController(bulletModel, bulleteTransform, bulletScriptableObject.bulletView);
    }

    private BulletScriptableObject GetBulletScriptablObject(BulletType bulletType)
    {
        BulletScriptableObject bulletScriptableObject;

        for(int i = 0; i < bulletList.bullets.Length; i++)
        {
            if(bulletList.bullets[i].bulletType == bulletType)
            {
                bulletScriptableObject = bulletList.bullets[i];
                return bulletScriptableObject;
            }
        }

        return null;
    }


}
