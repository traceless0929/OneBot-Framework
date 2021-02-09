﻿using System;
using QQRobot.CommandRoute;

namespace QQRobot.Attribute
{
    /// <summary>
    /// 指令路由
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class CommandAttribute : System.Attribute
    {
        /// <summary>
        /// 指令格式
        /// </summary>
        public string Pattern { get; private set; } = "";

        /// <summary>
        /// 指令别名
        /// </summary>
        public string Alias { get; set; } = "";

        /// <summary>
        /// 事件类型
        /// </summary>
        public EventType EventType { get; set; } = EventType.GroupMessage;

        /// <summary>
        /// 指令路由
        /// </summary>
        /// <param name="pattern">指令格式</param>
        public CommandAttribute(String pattern)
        {
            Pattern = pattern;
        }
    }
}