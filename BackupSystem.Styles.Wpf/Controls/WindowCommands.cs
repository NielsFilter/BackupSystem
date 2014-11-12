﻿using System.Windows;
using System.Windows.Controls;

namespace BackupSystem.Styles.Wpf.Controls
{
    public class WindowCommands : ItemsControl
    {
        static WindowCommands()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowCommands), new FrameworkPropertyMetadata(typeof(WindowCommands)));
        }
    }
}
