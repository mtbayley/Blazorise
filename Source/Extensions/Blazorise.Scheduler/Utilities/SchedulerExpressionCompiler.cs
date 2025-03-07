﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
#endregion

namespace Blazorise.Scheduler.Utilities;

/// <summary>
/// Utility class for compiling expressions.
/// </summary>
public static class SchedulerExpressionCompiler
{
    /// <summary>
    /// Builds a search predicate for the given item type.
    /// </summary>
    /// <typeparam name="TItem">The type of the item.</typeparam>
    /// <param name="startFieldName">The name of the field that represents the start date/time.</param>
    /// <param name="endFieldName">The name of the field that represents the end date/time.</param>
    /// <returns>A compiled search predicate.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static Func<TItem, DateOnly, int, TimeSpan, bool> BuildSearchPredicate<TItem>( string startFieldName, string endFieldName )
    {
        var itemType = typeof( TItem );
        var itemParameter = Expression.Parameter( itemType, "x" );
        var dateParameter = Expression.Parameter( typeof( DateOnly ), "date" );
        var slotHourParameter = Expression.Parameter( typeof( int ), "slotHour" );
        var timeParameter = Expression.Parameter( typeof( TimeSpan ), "time" );

        var startProperty = itemType.GetProperty( startFieldName );
        var endProperty = itemType.GetProperty( endFieldName );

        if ( startProperty == null || endProperty == null )
        {
            throw new ArgumentException( "Invalid field names for Start or End." );
        }

        var startPropertyAccess = Expression.Property( itemParameter, startProperty );
        var endPropertyAccess = Expression.Property( itemParameter, endProperty );

        var startDateTime = ConvertToDateTimeExpression( startPropertyAccess, dateParameter );
        var endDateTime = ConvertToDateTimeExpression( endPropertyAccess, dateParameter );

        var dateCondition = Expression.Equal(
            Expression.Property( startDateTime, nameof( DateTime.Date ) ),
            Expression.Property( Expression.Call( dateParameter, nameof( DateOnly.ToDateTime ), null, Expression.Constant( TimeOnly.MinValue ) ), nameof( DateTime.Date ) )
        );

        var hourCondition = Expression.Equal(
            Expression.Property( startDateTime, nameof( DateTime.Hour ) ),
            slotHourParameter
        );

        var minuteCondition = Expression.AndAlso(
            Expression.GreaterThanOrEqual(
                Expression.Property( startDateTime, nameof( DateTime.Minute ) ),
                Expression.Property( timeParameter, nameof( TimeSpan.Minutes ) )
            ),
            Expression.LessThanOrEqual(
                Expression.Property( startDateTime, nameof( DateTime.Minute ) ),
                Expression.Property( timeParameter, nameof( TimeSpan.Minutes ) )
            )
        );

        var combinedCondition = Expression.AndAlso( dateCondition, Expression.AndAlso( hourCondition, minuteCondition ) );

        var lambda = Expression.Lambda<Func<TItem, DateOnly, int, TimeSpan, bool>>(
            combinedCondition, itemParameter, dateParameter, slotHourParameter, timeParameter
        );

        return lambda.Compile();
    }

    private static Expression ConvertToDateTimeExpression( Expression propertyAccess, ParameterExpression dateParameter )
    {
        if ( propertyAccess.Type == typeof( DateTime ) )
        {
            return propertyAccess;
        }
        else if ( propertyAccess.Type == typeof( TimeOnly ) )
        {
            var toDateTimeMethod = typeof( DateOnly ).GetMethod( nameof( DateOnly.ToDateTime ), new[] { typeof( TimeOnly ) } );
            return Expression.Call( dateParameter, toDateTimeMethod, propertyAccess );
        }
        else
        {
            throw new ArgumentException( "Field must be of type DateTime or TimeOnly." );
        }
    }

    /// <summary>
    /// Builds a function that returns a string value for the given field name.
    /// </summary>
    /// <typeparam name="TItem">The type of the item.</typeparam>
    /// <param name="fieldName">The name of the field that represents the title.</param>
    /// <returns>A compiled function that returns a string value for the given field name.</returns>
    public static Func<TItem, string> BuildGetStringFunc<TItem>( string fieldName )
    {
        var itemType = typeof( TItem );
        var itemParameter = Expression.Parameter( itemType, "x" );

        var property = itemType.GetProperty( fieldName );

        if ( property == null )
        {
            return null;
        }

        var titlePropertyAccess = Expression.Property( itemParameter, property );

        var lambda = Expression.Lambda<Func<TItem, string>>( titlePropertyAccess, itemParameter );

        return lambda.Compile();
    }

    public static Func<TItem, object> BuildGetValueFunc<TItem>( string fieldName )
    {
        var itemType = typeof( TItem );
        var itemParameter = Expression.Parameter( itemType, "x" );

        var property = itemType.GetProperty( fieldName );

        if ( property == null )
        {
            return null;
        }

        var propertyAccess = Expression.Property( itemParameter, property );
        var convert = Expression.Convert( propertyAccess, typeof( object ) );

        var lambda = Expression.Lambda<Func<TItem, object>>( convert, itemParameter );

        return lambda.Compile();
    }

    public static Expression<Func<TItem, object>> CreateValueGetterExpression<TItem>( string fieldName )
    {
        var item = Expression.Parameter( typeof( TItem ), "item" );
        var property = GetSafePropertyOrFieldExpression( item, fieldName );
        return Expression.Lambda<Func<TItem, object>>( Expression.Convert( property, typeof( object ) ), item );
    }

    public static Expression GetSafePropertyOrFieldExpression( Expression item, string propertyOrFieldName )
    {
        if ( string.IsNullOrEmpty( propertyOrFieldName ) )
            throw new ArgumentException( $"{nameof( propertyOrFieldName )} is not specified." );

        var parts = propertyOrFieldName.Split( new char[] { '.' }, 2 );

        Expression field = null;

        MemberInfo memberInfo = GetSafeMember( item.Type, parts[0] );

        if ( memberInfo is PropertyInfo propertyInfo )
            field = Expression.Property( item, propertyInfo );
        else if ( memberInfo is FieldInfo fieldInfo )
            field = Expression.Field( item, fieldInfo );

        if ( field == null )
            throw new ArgumentException( $"Cannot detect the member of {item.Type}", propertyOrFieldName );

        field = Expression.Condition( Expression.Equal( item, Expression.Default( item.Type ) ),
            IsNullable( field.Type ) ? Expression.Constant( null, field.Type ) : Expression.Default( field.Type ),
            field );

        if ( parts.Length > 1 )
            field = GetSafePropertyOrFieldExpression( field, parts[1] );

        return field;
    }

    public static MemberExpression GetPropertyOrFieldExpression( Expression item, string propertyOrFieldName )
    {
        if ( string.IsNullOrEmpty( propertyOrFieldName ) )
            throw new ArgumentException( $"{nameof( propertyOrFieldName )} is not specified." );

        var parts = propertyOrFieldName.Split( new char[] { '.' }, 2 );

        MemberExpression field = null;

        MemberInfo memberInfo = GetSafeMember( item.Type, parts[0] );

        if ( memberInfo is PropertyInfo propertyInfo )
            field = Expression.Property( item, propertyInfo );
        else if ( memberInfo is FieldInfo fieldInfo )
            field = Expression.Field( item, fieldInfo );

        if ( field == null )
            throw new ArgumentException( $"Cannot detect the member of {item.Type}", propertyOrFieldName );

        if ( parts.Length > 1 )
            field = GetPropertyOrFieldExpression( field, parts[1] );

        return field;
    }

    private static MemberInfo GetSafeMember( Type type, string fieldName )
    {
        MemberInfo memberInfo = (MemberInfo)type.GetProperty( fieldName )
                                ?? type.GetField( fieldName );

        if ( memberInfo == null )
        {
            var baseTypesAndInterfaces = new List<Type>();

            if ( type.BaseType != null )
            {
                baseTypesAndInterfaces.Add( type.BaseType );
            }

            baseTypesAndInterfaces.AddRange( type.GetInterfaces() );

            foreach ( var baseType in baseTypesAndInterfaces )
            {
                memberInfo = GetSafeMember( baseType, fieldName );

                if ( memberInfo != null )
                    break;
            }
        }

        return memberInfo;
    }

    private static bool IsNullable( Type type )
    {
        if ( type.IsClass )
            return true;

        return type.IsGenericType && type.GetGenericTypeDefinition() == typeof( Nullable<> );
    }
}
