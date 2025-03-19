﻿#region Using directives
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazorise.Extensions;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise.Charts.DataLabels;

/// <summary>
/// Highly customizable Chart.js plugin that displays labels on data for any type of charts.
/// </summary>
/// <typeparam name="TItem">Generic dataset value type.</typeparam>
public partial class ChartDataLabels<TItem> : ChartPlugin<TItem, JSChartDataLabelsModule>
{
    #region Methods

    protected override JSChartDataLabelsModule GetNewJsModule()
    {
        return new JSChartDataLabelsModule( JSRuntime, VersionProvider, BlazoriseOptions );
    }

    protected override async Task InitializePluginByJsModule()
    {
        await JSModule.SetDataLabels( ParentChart.ElementId, Datasets, Options );
    }

    protected override bool InitPluginInParameterSet( ParameterView parameters )
    {
        var datasetsChanged = parameters.TryGetValue<List<ChartDataLabelsDataset>>( nameof( Datasets ), out var paramDataset ) && !Datasets.AreEqual( paramDataset );
        var optionsChanged = parameters.TryGetValue<ChartDataLabelsOptions>( nameof( Options ), out var paramOptions ) && !Options.IsEqual( paramOptions );
        return datasetsChanged || optionsChanged;
    }

    #endregion

    #region Properties


    /// <summary>
    /// JS module that handles the calls to the datalabels JS interop.
    /// </summary>
    protected override JSChartDataLabelsModule JSModule { get; set; }

    /// <summary>
    /// List of datalabels to apply to the parent chart.
    /// </summary>
    [Parameter] public List<ChartDataLabelsDataset> Datasets { get; set; }

    /// <summary>
    /// Data labels that will be set to the options instead of to the datasets.
    /// </summary>
    [Parameter] public ChartDataLabelsOptions Options { get; set; }

    protected override string Name => "DataLabels";

    #endregion
}