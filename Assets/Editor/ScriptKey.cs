using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;
using System.Collections.Generic;

/**
 * 项目名称： #PROJECTNAME#
 * 文件名： ScriptKey.cs
 * 类描述：Editor脚本，监听Project视图中资源的创建、删除、移动、保存。当创建C#脚本时自动添加文件头信息。
 * 创建人：77.
 * 创建时间： #CREATIONDATE#
 * 修改备注：
 * QQ：951203598
 */

public class ScriptKey : UnityEditor.AssetModificationProcessor
{
    public static void OnWillCreateAsset (string path)
    {
        path = path.Replace ( ".meta" ,"" );

        if ( path.EndsWith ( ".cs" ) )
        {
            // 读取脚本的位置。
            string text = File.ReadAllText ( path );
            // 将脚本中的创建时间替换成当前系统的时间
            text = text.Replace ( "#CREATIONDATE#" ,System.DateTime.Now.ToString ( ) );
            text = text.Replace ( "#PROJECTNAME#" ,PlayerSettings.productName );
            text = text.Replace ( "#FILEEXTENSION#" ,".cs" );

            //  将替换后的。重新写入脚本
            File.WriteAllText ( path ,text );

            // 更新Unity的资源数据
            AssetDatabase.Refresh ( );
        }
    }
}