using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    [SerializeField] int enemyTypeLimit;

    
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies(enemyTypeLimit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemies(int limit)
    {

    }
}
