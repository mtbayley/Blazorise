﻿#region Using directives
using System;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise.Scheduler.Components;

public partial class _SchedulerDayView<TItem>
{
    #region Members

    #endregion

    #region Methods

    #endregion

    #region Properties

    [Parameter] public DateOnly SelectedDate { get; set; }

    [Parameter] public TimeOnly? StartTime { get; set; }

    [Parameter] public TimeOnly? EndTime { get; set; }

    #endregion
}
