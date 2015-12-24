using UnityEngine;
using System.Collections;

/**
 * 项目名称：Running
 * 文件名： Button.cs
 * 创建时间：12/24/2015 9:25:01 PM
 * 创建人：77.
 * 类描述：
 * 修改备注：
 * QQ：951203598
 */

public class Button : MonoBehaviour
{
    void Awake ( )
    {
        GetListener ( "Play" ,Play );
        GetListener ( "Quit" ,Quit );
    }
    private void Play (GameObject button)
    {
        Application.LoadLevel ( "Scenes" );
    }

    private void Quit (GameObject button)
    {
        Application.Quit ( );
    }

    private void GetListener (string buttonName ,UIEventListener.VoidDelegate methodName)
    {
        GameObject obj = GameObject.Find ( "UI Root/" + buttonName );
        UIEventListener.Get ( obj ).onClick = methodName;
    }
}
