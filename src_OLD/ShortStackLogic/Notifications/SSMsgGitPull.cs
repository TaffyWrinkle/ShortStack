﻿using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Tools.Productivity.ShortStack
{
    //---------------------------------------------------------------------------------
    /// <summary>
    /// Notification for a git Pull
    /// </summary>
    //---------------------------------------------------------------------------------
    public class SSMsgGitPull
    {
        public string FromBranchName { get; set; }
        public string ToBranchName { get; set; }
    }
}
