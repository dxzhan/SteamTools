#nullable enable
#pragma warning disable IDE0079 // 请删除不必要的忽略
#pragma warning disable SA1634 // File header should show copyright
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
#pragma warning disable CS0108 // 成员隐藏继承的成员；缺少关键字 new
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由包 BD.Common.Settings.V4.SourceGenerator.Tools 源生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace BD.WTTS.Settings.Abstractions;

public partial interface ISteamIdleSettings
{
    static ISteamIdleSettings? Instance
        => Ioc.Get_Nullable<IOptionsMonitor<ISteamIdleSettings>>()?.CurrentValue;

    /// <summary>
    /// 挂卡状态更新时间
    /// </summary>
    TimeSpan IdleTime { get; set; }

    /// <summary>
    /// 运行规则
    /// </summary>
    IdleRule IdleRule { get; set; }

    /// <summary>
    /// 运行顺序
    /// </summary>
    IdleSequentital IdleSequentital { get; set; }

    /// <summary>
    /// 自动运行下一个游戏
    /// </summary>
    bool IsAutoNextOn { get; set; }

    /// <summary>
    /// 最少游戏时间 hours
    /// </summary>
    double MinRunTime { get; set; }

    /// <summary>
    /// 自动切换游戏时间间隔 ms
    /// </summary>
    double SwitchTime { get; set; }

    /// <summary>
    /// 自动刷新徽章数据时间间隔 min
    /// </summary>
    double RefreshBadgesTime { get; set; }

    /// <summary>
    /// 挂卡状态更新时间的默认值
    /// </summary>
    static readonly TimeSpan DefaultIdleTime = TimeSpan.FromMinutes(6);

    /// <summary>
    /// 运行规则的默认值
    /// </summary>
    static readonly IdleRule DefaultIdleRule = IdleRule.OnlyOneGame;

    /// <summary>
    /// 运行顺序的默认值
    /// </summary>
    static readonly IdleSequentital DefaultIdleSequentital = IdleSequentital.Default;

    /// <summary>
    /// 自动运行下一个游戏的默认值
    /// </summary>
    static readonly bool DefaultIsAutoNextOn = false;

    /// <summary>
    /// 最少游戏时间 hours的默认值
    /// </summary>
    static readonly double DefaultMinRunTime = 2;

    /// <summary>
    /// 自动切换游戏时间间隔 ms的默认值
    /// </summary>
    static readonly double DefaultSwitchTime = 1000;

    /// <summary>
    /// 自动刷新徽章数据时间间隔 min的默认值
    /// </summary>
    static readonly double DefaultRefreshBadgesTime = 6;

}
