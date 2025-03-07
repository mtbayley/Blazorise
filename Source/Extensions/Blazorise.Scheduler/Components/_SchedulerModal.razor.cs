﻿#region Using directives
using System;
using System.Threading.Tasks;
using Blazorise.Scheduler.Utilities;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise.Scheduler.Components;

public partial class _SchedulerModal<TItem>
{
    #region Members

    private Modal modalRef;

    private Func<TItem, object> getTitleValue;
    private Action<TItem, object> setTitleValue;

    private Func<TItem, object> getDescriptionValue;
    private Action<TItem, object> setDescriptionValue;

    private Func<TItem, object> getStartValue;
    private Action<TItem, object> setStartValue;

    private Func<TItem, object> getEndValue;
    private Action<TItem, object> setEndValue;

    private readonly Lazy<Func<TItem>> newItemCreator;

    #endregion

    #region Constructors

    public _SchedulerModal()
    {
        newItemCreator = new( () => SchedulerFunctionCompiler.CreateNewItem<TItem>() );
    }

    #endregion

    protected override void OnInitialized()
    {
        if ( typeof( TItem ).GetProperty( TitleField ).PropertyType is not null )
        {
            getTitleValue = SchedulerFunctionCompiler.CreateValueGetter<TItem>( TitleField );
            setTitleValue = SchedulerFunctionCompiler.CreateValueSetter<TItem>( TitleField );
        }

        if ( typeof( TItem ).GetProperty( DescriptionField ).PropertyType is not null )
        {
            getDescriptionValue = SchedulerFunctionCompiler.CreateValueGetter<TItem>( DescriptionField );
            setDescriptionValue = SchedulerFunctionCompiler.CreateValueSetter<TItem>( DescriptionField );
        }

        if ( typeof( TItem ).GetProperty( StartField ).PropertyType is not null )
        {
            getStartValue = SchedulerFunctionCompiler.CreateValueGetter<TItem>( StartField );
            setStartValue = SchedulerFunctionCompiler.CreateValueSetter<TItem>( StartField );
        }

        if ( typeof( TItem ).GetProperty( EndField ).PropertyType is not null )
        {
            getEndValue = SchedulerFunctionCompiler.CreateValueGetter<TItem>( EndField );
            setEndValue = SchedulerFunctionCompiler.CreateValueSetter<TItem>( EndField );
        }

        base.OnInitialized();
    }

    #region Methods

    public Task ShowModal( TItem item )
    {
        if ( item is null )
            EditItem = newItemCreator.Value();
        else
            EditItem = item;

        if ( EditItem is not null )
        {
            Title = getTitleValue?.Invoke( EditItem )?.ToString();
            Description = getDescriptionValue?.Invoke( EditItem )?.ToString();
            Start = (DateTime)getStartValue?.Invoke( EditItem );
            End = (DateTime)getEndValue?.Invoke( EditItem );
        }

        return modalRef.Show();
    }

    public async Task Cancel()
    {
        await modalRef.Hide();
    }

    public async Task Submit()
    {
        if ( EditItem is not null )
        {
            setTitleValue?.Invoke( EditItem, Title );
            setDescriptionValue?.Invoke( EditItem, Description );
            setStartValue?.Invoke( EditItem, Start );
            setEndValue?.Invoke( EditItem, End );

            await Saved.InvokeAsync( EditItem );
        }

        await modalRef.Hide();
    }

    #endregion

    #region Properties

    protected bool TitleAvailable => getTitleValue is not null;

    protected bool DescriptionAvailable => getDescriptionValue is not null;

    protected bool StartAvailable => getStartValue is not null;

    protected bool EndAvailable => getEndValue is not null;

    protected string Title { get; set; }

    protected string Description { get; set; }

    protected DateTime Start { get; set; }

    protected DateTime End { get; set; }

    public TItem EditItem { get; set; }

    /// <summary>
    /// Defines the field name of the <see cref="Scheduler{TItem}"/> that represents the start date of the appointment. Defaults to "Start".
    /// </summary>
    [Parameter] public string StartField { get; set; }

    /// <summary>
    /// Defines the field name of the <see cref="Scheduler{TItem}"/> that represents the end date of the appointment. Defaults to "End".
    /// </summary>
    [Parameter] public string EndField { get; set; }

    /// <summary>
    /// Defines the field name of the <see cref="Scheduler{TItem}"/> that represents the title of the appointment. Defaults to "Title".
    /// </summary>
    [Parameter] public string TitleField { get; set; }

    /// <summary>
    /// Defines the field name of the <see cref="Scheduler{TItem}"/> that represents the description of the appointment. Defaults to "Description".
    /// </summary>
    [Parameter] public string DescriptionField { get; set; }

    [Parameter] public EventCallback<TItem> Saved { get; set; }

    #endregion
}
