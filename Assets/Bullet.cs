using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 12f;
    public float maxLifeTime = 3f;
    public string targetTag = "Target";

    public static event Action<GameObject> OnHitTarget;

    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        // GameObject bullet = BulletPool.SharedInstance.GetPooledObject();
        // if (bullet != null) {
        //     bullet.SetActive(true);
        // }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
