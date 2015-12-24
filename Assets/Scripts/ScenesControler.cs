using UnityEngine;
using System.Collections;

/**
 * 项目名称：Running
 * 文件名： ScenesControler.cs
 * 创建时间：12/22/2015 8:29:22 PM
 * 创建人：77.
 * 类描述：负责场景道具的出现/位移/旋转等管理。
 * 修改备注：
 * QQ：951203598
 */

public class ScenesControler : MonoBehaviour
{
    // 场景
    public GameObject Wall;
    // 主角
    public GameObject Player;
    // 移动速度
    public float MoveSpeed = 1f;
    // 初始数值
    private Vector3 vecWallOriginalPosition;
    void Start ( )
    {
        // 获得初始数值
        vecWallOriginalPosition = Wall.transform.position;
        // 动画速度
        Player.GetComponent<Animation> ( )[ "walk" ].speed = 5.0f;
    }

    void Update ( )
    {
        if ( Wall.transform.position.z < -60 )
        {
            // 恢复初始数值
            Wall.transform.position = vecWallOriginalPosition;
        }
        Wall.transform.Translate ( Vector3.back * MoveSpeed );
    }
}
