using System;
using System.Collections.Generic;
using System.Text;

namespace Weekly_Planner.Models
{
    public class ActivityChangeTypeEventArgs : EventArgs
    {
        public ActivityDetails[]? Old { get; } = null;
        public ActivityDetails[]? New { get; } = null;

        public ActivityChangeType ChangeType { get;}

        public ActivityChangeTypeEventArgs(ActivityChangeType changeType, ActivityDetails[]? old, ActivityDetails[]? New)
        {
            this.New = New;
            this.Old = old;
            this.ChangeType = changeType;
        }

    }
}
