using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugExcel : MonoBehaviour
{
    [SerializeField]
    private EnemyTestGame20190808 enemy;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0;i<enemy.data.Count ;i++ )
        {
            Debug.Log(enemy.data[i].NAME+"属性："+enemy.data[i].ZOKUSEI.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
