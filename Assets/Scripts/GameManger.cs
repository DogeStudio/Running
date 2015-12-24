using UnityEngine;
using System.Collections;

/**
 * 项目名称：Running
 * 文件名： GameManger.cs
 * 创建时间：12/23/2015 8:38:53 PM
 * 创建人：77.
 * 类描述：全局游戏管理
 * 修改备注：
 * QQ：951203598
 */

/// <summary>
/// 音量大小
/// Null:           占位
/// MaxVolumes:     最大音量
/// NormalVolumns:  普通音量
/// MinVolums:      最小音量
/// </summary>
public enum AudioVolumes
{
    Null ,
    MaxVolumes ,
    NormalVolumns ,
    MinVolums
};

/// <summary>
/// 游戏状态
/// Null:           占位
/// GamePrepare:    游戏准备
/// GamePlaying:    正在游戏
/// GameOver:       游戏结束
/// GamePause:      游戏暂停
/// </summary>
public enum GameState
{
    Null ,
    GamePrepare ,
    GamePlaying ,
    GameOver ,
    GamePause
};

/// <summary>
/// 动作
/// Null:   无
/// Walk:   走
/// Run:    跑
/// Jump:   跳
/// Bend:   卧
/// </summary>
public enum PlayerActions
{
    Null ,
    Walk ,
    Run ,
    Jump ,
    Bend
};
public class GameManger : MonoBehaviour
{
    // 全局音量
    public static AudioVolumes GlobalAudioVolumes = AudioVolumes.MaxVolumes;
    // 游戏状态
    public static GameState GlobalGameState = GameState.Null;
    // 金币数量
    public static int IntGold = 0;
    // 里程
    public static int IntRunningLength = 0;
    // 玩家动作
    public static PlayerActions GlobalPlayerActions = PlayerActions.Null;

    void Update ( )
    {
        if ( Input.GetKey(KeyCode.Escape) )
        {

        }
    }
}
