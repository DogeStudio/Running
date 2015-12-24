using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/**
 * 项目名称：Running
 * 文件名： HUDUserInterface.cs
 * 创建时间：12/23/2015 8:23:25 PM
 * 创建人：77.
 * 类描述：用户面板
 * 修改备注：
 * QQ：951203598
 */

public class HUDUserInterface : MonoBehaviour
{
    public Text meter;
    private float intMeter;
    void Start ( )
    {

    }

    void Update ( )
    {
        intMeter += 0.1f;
        meter.text = "距离:" + (int)intMeter + "米";
    }
}
