using BackupSystem.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.ApplicationLogic.ViewModels.Base
{
    public interface IParentViewModel
    {
        bool IsLoading { get; set; }
        string LoadingMessage { get; set; }
        void ShowPanelMessage(UserMessageType msgType, string caption, string message);
    }
}
