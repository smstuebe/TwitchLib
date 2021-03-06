﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Events.Client
{
    /// <summary>Args representing on connected event.</summary>
    public class OnConnectedArgs : EventArgs
    {
        /// <summary>Property representing bot username.</summary>
        public string Username;
        /// <summary>Property representing connected channel.</summary>
        public string AutoJoinChannel;
    }
}
