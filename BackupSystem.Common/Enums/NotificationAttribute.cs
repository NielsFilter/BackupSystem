﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackupSystem.Common.Enums
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
    public class NotificationAttribute : Attribute
    {
        public NotificationAttribute(string caption, string message)
        {
            this.Caption = caption;
            this.Message = message;
        }

        public string Caption { get; set; }
        public string Message { get; set; }

        #region Public Static Methods

        public static NotificationAttribute GetAttribute(UserMessageType type)
        {
            var mi = type.GetType().GetMember(type.ToString());
            if (mi != null && mi.Length > 0)
            {
                var attr = Attribute.GetCustomAttribute(mi[0], typeof(NotificationAttribute));
                if (attr != null)
                {
                    return (NotificationAttribute)attr;
                }
            }
            return null;
        }

        public static string GetCaption(UserMessageType type)
        {
            var attr = GetAttribute(type);

            if (attr == null)
            {
                return string.Empty;
            }
            else
            {
                return attr.Caption;
            }
        }

        public static string GetMessage(UserMessageType type)
        {
            var attr = GetAttribute(type);

            if (attr == null)
            {
                return string.Empty;
            }
            else
            {
                return attr.Message;
            }
        }

        #endregion
    }
}
