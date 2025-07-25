﻿#region Using directives
using System.Collections.Generic;
#endregion

namespace Blazorise;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
public interface IClassProvider
{
    #region TextEdit

    string TextEdit( bool plaintext );

    string TextEditSize( Size size );

    string TextEditColor( Color color );

    string TextEditValidation( ValidationStatus validationStatus );

    #endregion

    #region MemoEdit

    string MemoEdit( bool plaintext );

    string MemoEditSize( Size size );

    string MemoEditValidation( ValidationStatus validationStatus );

    #endregion

    #region Select

    string Select();

    string SelectMultiple( bool multiple );

    string SelectSize( Size size );

    string SelectValidation( ValidationStatus validationStatus );

    #endregion

    #region NumericEdit

    string NumericEdit( bool plaintext );

    string NumericEditSize( Size size );

    string NumericEditColor( Color color );

    string NumericEditValidation( ValidationStatus validationStatus );

    #endregion

    #region DateEdit

    string DateEdit( bool plaintext );

    string DateEditSize( Size size );

    string DateEditColor( Color color );

    string DateEditValidation( ValidationStatus validationStatus );

    #endregion

    #region TimeEdit

    string TimeEdit( bool plaintext );

    string TimeEditSize( Size size );

    string TimeEditColor( Color color );

    string TimeEditValidation( ValidationStatus validationStatus );

    #endregion

    #region ColorEdit

    string ColorEdit();

    string ColorEditSize( Size size );

    #endregion

    #region DatePicker

    string DatePicker( bool plaintext );

    string DatePickerSize( Size size );

    string DatePickerColor( Color color );

    string DatePickerValidation( ValidationStatus validationStatus );

    #endregion

    #region TimePicker

    string TimePicker( bool plaintext );

    string TimePickerSize( Size size );

    string TimePickerColor( Color color );

    string TimePickerValidation( ValidationStatus validationStatus );

    #endregion

    #region ColorPicker

    string ColorPicker();

    string ColorPickerSize( Size size );

    #endregion

    #region NumericPicker

    string NumericPicker( bool plaintext );

    string NumericPickerSize( Size size );

    string NumericPickerColor( Color color );

    string NumericPickerValidation( ValidationStatus validationStatus );

    #endregion

    #region InputMask

    string InputMask( bool plaintext );

    string InputMaskSize( Size size );

    string InputMaskColor( Color color );

    string InputMaskValidation( ValidationStatus validationStatus );

    #endregion

    #region Check

    string Check();

    string CheckSize( Size size );

    string CheckInline( bool inline );

    string CheckCursor( Cursor cursor );

    string CheckValidation( ValidationStatus validationStatus );

    #endregion

    #region RadioGroup

    string RadioGroup( bool buttons, Orientation orientation );

    public string RadioGroupSize( bool buttons, Orientation orientation, Size size );

    string RadioGroupValidation( ValidationStatus validationStatus );

    #endregion

    #region Radio

    string Radio( bool button );

    string RadioSize( bool button, Size size );

    string RadioInline( bool inline );

    string RadioCursor( Cursor cursor );

    string RadioValidation( ValidationStatus validationStatus );

    #endregion

    #region Switch

    string Switch();

    string SwitchColor( Color color );

    string SwitchSize( Size size );

    string SwitchChecked( bool @checked );

    string SwitchCursor( Cursor cursor );

    string SwitchValidation( ValidationStatus validationStatus );

    #endregion

    #region FileEdit

    string FileEdit();

    string FileEditSize( Size size );

    string FileEditValidation( ValidationStatus validationStatus );

    #endregion

    #region Slider

    string Slider();

    string SliderColor( Color color );

    string SliderValidation( ValidationStatus validationStatus );

    #endregion

    #region Rating

    string Rating();

    string RatingDisabled( bool disabled );

    string RatingReadonly( bool @readonly );

    string RatingItem();

    string RatingItemColor( Color color );

    string RatingItemSelected( bool selected );

    string RatingItemHovered( bool hover );

    #endregion

    #region Label

    string LabelType( LabelType labelType );

    string LabelCursor( Cursor cursor );

    #endregion

    #region Help

    string Help();

    #endregion

    #region Validation

    string ValidationSuccess();

    string ValidationSuccessTooltip();

    string ValidationError();

    string ValidationErrorTooltip();

    string ValidationNone();

    string ValidationSummary();

    string ValidationSummaryError();

    #endregion

    #region Fields

    string Fields();

    string FieldsBody();

    string FieldsColumn();

    #endregion

    #region Field

    string Field();

    string FieldHorizontal( bool horizontal );

    string FieldColumn();

    string FieldSize( Size size );

    string FieldValidation( ValidationStatus validationStatus );

    string FieldJustifyContent( JustifyContent justifyContent );

    #endregion

    #region FieldLabel

    string FieldLabel( bool horizontal );

    string FieldLabelRequiredIndicator( bool requiredIndicator );

    string FieldLabelScreenreader( Screenreader screenreader );

    #endregion

    #region FieldBody

    string FieldBody();

    #endregion

    #region FieldHelp

    string FieldHelp();

    #endregion

    #region FocusTrap

    string FocusTrap();

    #endregion

    #region Control

    string ControlCheck( ControlRole role );

    string ControlRadio( ControlRole role );

    string ControlSwitch( ControlRole role );

    string ControlFile( ControlRole role );

    string ControlText( ControlRole role );

    string ControlInline( ControlRole role, bool inline );

    #endregion

    #region Addons

    string Addons();

    string AddonsSize( Size size );

    string AddonsHasButton( bool hasButton );

    string Addon( AddonType addonType );

    string AddonSize( Size size );

    string AddonLabel();

    #endregion

    #region Inline

    string Inline();

    #endregion

    #region Button

    string Button( bool outline );

    string ButtonColor( Color color, bool outline );

    string ButtonSize( Size size, bool outline );

    string ButtonBlock( bool outline, bool block );

    string ButtonActive( bool outline, bool active );

    string ButtonDisabled( bool outline, bool disabled );

    string ButtonLoading( bool outline, bool loading );

    string ButtonStretchedLink( bool stretched );

    #endregion

    #region Buttons

    string Buttons( ButtonsRole role, Orientation orientation );

    string ButtonsSize( Size size );

    #endregion

    #region CloseButton

    string CloseButton();

    #endregion

    #region Dropdown

    string Dropdown( bool isDropdownSubmenu );

    string DropdownDisabled( bool disabled );

    string DropdownGroup( bool group );

    string DropdownObserverShow();

    string DropdownShow( bool show );

    string DropdownRight( bool rightAligned );

    string DropdownItem();

    string DropdownItemActive( bool active );

    string DropdownItemDisabled( bool disabled );

    string DropdownDivider();

    string DropdownHeader();

    string DropdownMenuPositionStrategy( DropdownPositionStrategy dropdownPositionStrategy );

    string DropdownFixedHeaderVisible( bool visible );

    string DropdownMenu();

    string DropdownMenuSelector();

    string DropdownMenuScrollable( bool scrollable );

    string DropdownMenuVisible( bool visible );

    string DropdownMenuRight( bool rightAligned );

    string DropdownToggle( bool isDropdownSubmenu, bool outline );

    string DropdownToggleSelector( bool isDropdownSubmenu );

    string DropdownToggleColor( Color color, bool outline );

    string DropdownToggleSize( Size size, bool outline );

    string DropdownToggleSplit( bool split );

    string DropdownToggleIcon( bool visible );

    string DropdownDirection( Direction direction );

    #endregion

    #region Tabs

    string Tabs( bool pills );

    string TabsCards( bool cards );

    string TabsFullWidth( bool fullWidth );

    string TabsJustified( bool justified );

    string TabsVertical( bool vertical );

    string TabItem( TabPosition tabPosition );

    string TabItemActive( bool active );

    string TabItemDisabled( bool disabled );

    string TabLink( TabPosition tabPosition );

    string TabLinkActive( bool active );

    string TabLinkDisabled( bool disabled );

    string TabsContent();

    string TabPanel();

    string TabPanelActive( bool active );

    #endregion

    #region Steps

    string Steps();

    string StepItem();

    string StepItemActive( bool active );

    string StepItemCompleted( bool completed );

    string StepItemColor( Color color );

    string StepItemMarker();

    string StepItemMarkerColor( Color color, bool active );

    string StepItemDescription();

    string StepsContent();

    string StepPanel();

    string StepPanelActive( bool active );

    #endregion

    #region Carousel

    string Carousel();

    string CarouselSlides();

    string CarouselSlide();

    string CarouselSlideActive( bool active );

    string CarouselSlideIndex( int activeSlideIndex, int slideindex, int totalSlides );

    string CarouselSlideSlidingLeft( bool left );

    string CarouselSlideSlidingRight( bool right );

    string CarouselSlideSlidingPrev( bool previous );

    string CarouselSlideSlidingNext( bool next );

    string CarouselIndicators();

    string CarouselIndicator();

    string CarouselIndicatorActive( bool active );

    string CarouselFade( bool fade );

    string CarouselCaption();

    #endregion

    #region Jumbotron

    string Jumbotron();

    string JumbotronBackground( Background background );

    string JumbotronTitle( JumbotronTitleSize jumbotronTitleSize );

    string JumbotronSubtitle();

    #endregion

    #region Card

    string CardDeck();

    string CardGroup();

    string Card();

    string CardWhiteText( bool whiteText );

    string CardActions();

    string CardBody();

    string CardFooter();

    string CardHeader();

    string CardImage();

    string CardTitle( bool insideHeader );

    string CardTitleSize( bool insideHeader, int? size );

    string CardSubtitle( bool insideHeader );

    string CardSubtitleSize( bool insideHeader, int size );

    string CardText();

    string CardLink();

    string CardLinkUnstyled( bool unstyled );

    string CardLinkActive( bool active );

    #endregion

    #region ListGroup

    string ListGroup();

    string ListGroupFlush( bool flush );

    string ListGroupScrollable( bool scrollable );

    string ListGroupItem();

    string ListGroupItemSelectable( bool selectable );

    string ListGroupItemActive( bool active );

    string ListGroupItemDisabled( bool disabled );

    string ListGroupItemColor( Color color, bool selectable, bool active );

    #endregion

    #region Layout

    string Layout();

    string LayoutHasSider( bool hasSider );

    string LayoutContent();

    string LayoutHeader();

    string LayoutHeaderFixed( bool @fixed );

    string LayoutFooter();

    string LayoutFooterFixed( bool @fixed );

    string LayoutSider();

    string LayoutSiderContent();

    string LayoutLoading();

    string LayoutRoot( bool root );

    #endregion

    #region Container

    string Container( Breakpoint breakpoint );

    string ContainerFluid();

    #endregion

    #region Bar

    string Bar( BarMode mode );

    string BarInitial( BarMode mode, bool initial );

    string BarAlignment( BarMode mode, Alignment alignment );

    string BarThemeContrast( BarMode mode, ThemeContrast themeContrast );

    string BarBreakpoint( BarMode mode, Breakpoint breakpoint );

    string BarMode( BarMode mode );

    string BarItem( BarMode mode, bool hasDropdown );

    string BarItemActive( BarMode mode, bool active );

    string BarItemDisabled( BarMode mode, bool disabled );

    string BarItemHasDropdown( BarMode mode, bool hasDropdown );

    string BarLink( BarMode mode );

    string BarLinkDisabled( BarMode mode, bool disabled );

    string BarBrand( BarMode mode );

    string BarToggler( BarMode mode, BarTogglerMode togglerMode );

    string BarTogglerCollapsed( BarMode mode, BarTogglerMode togglerMode, bool isShow );

    string BarMenu( BarMode mode );

    string BarMenuShow( BarMode mode, bool show );

    string BarStart( BarMode mode );

    string BarEnd( BarMode mode );

    string BarDropdown( BarMode mode, bool isBarDropDownSubmenu );

    string BarDropdownShow( BarMode mode, bool show );

    string BarDropdownToggle( BarMode mode, bool isBarDropDownSubmenu );

    string BarDropdownToggleDisabled( BarMode mode, bool isBarDropDownSubmenu, bool disabled );

    string BarDropdownItem( BarMode mode );

    string BarDropdownItemDisabled( BarMode mode, bool disabled );

    string BarDropdownDivider( BarMode mode );

    string BarTogglerIcon( BarMode mode );

    string BarDropdownMenu( BarMode mode );

    string BarDropdownMenuVisible( BarMode mode, bool visible );

    string BarDropdownMenuRight( BarMode mode, bool rightAligned );

    string BarDropdownMenuContainer( BarMode mode );

    string BarCollapsed( BarMode mode, bool visible );

    string BarLabel( BarMode mode );

    #endregion

    #region Accordion

    string Accordion();

    string AccordionToggle();

    string AccordionToggleCollapsed( bool collapsed );

    string AccordionItem();

    string AccordionItemActive( bool active );

    string AccordionHeader();

    string AccordionBody();

    string AccordionBodyActive( bool active );

    string AccordionBodyContent( bool firstInAccordion, bool lastInAccordion );

    #endregion

    #region Collapse

    string Collapse( bool accordion );

    string CollapseActive( bool accordion, bool active );

    string CollapseHeader( bool accordion );

    string CollapseBody( bool accordion );

    string CollapseBodyActive( bool accordion, bool active );

    string CollapseBodyContent( bool accordion, bool firstInAccordion, bool lastInAccordion );

    #endregion

    #region Row

    string Row();

    string RowColumns( RowColumnsSize rowColumnsSize, RowColumnsDefinition rowColumnsDefinition );

    string RowNoGutters( bool noGutters );

    #endregion

    #region Column

    string Column( bool grid, bool hasSizes );

    string Column( bool grid, ColumnWidth columnWidth, Breakpoint breakpoint, bool offset );

    string Column( bool grid, IEnumerable<ColumnDefinition> columnDefinitions );

    #endregion

    #region Grid

    string Grid();

    string GridRows( GridRowsSize gridRows, GridRowsDefinition gridRowsDefinition );

    string GridColumns( GridColumnsSize gridColumns, GridColumnsDefinition gridColumnsDefinition );

    #endregion

    #region Display

    string Display( DisplayType displayType, DisplayDefinition displayDefinition );

    string Display( DisplayType displayType, IEnumerable<DisplayDefinition> displayDefinitions );

    #endregion

    #region Alert

    string Alert();

    string AlertColor( Color color );

    string AlertDismisable( bool dismissable );

    string AlertFade( bool dismissable );

    string AlertShow( bool dismissable, bool visible );

    string AlertHasMessage( bool hasMessage );

    string AlertHasDescription( bool hasDescription );

    string AlertMessage();

    string AlertDescription();

    #endregion

    #region Modal

    string Modal();

    string ModalFade( bool showing, bool hiding );

    string ModalVisible( bool visible );

    string ModalSize( ModalSize modalSize );

    string ModalCentered( bool centered );

    string ModalBackdrop();

    string ModalBackdropFade();

    string ModalBackdropVisible( bool visible );

    string ModalContent( bool dialog );

    string ModalContentSize( ModalSize modalSize );

    string ModalContentCentered( bool centered );

    string ModalContentScrollable( bool scrollable );

    string ModalBody();

    string ModalHeader();

    string ModalFooter();

    string ModalTitle();

    #endregion

    #region Offcanvas

    string Offcanvas();

    string OffcanvasPlacement( Placement placement, bool visible );

    string OffcanvasFade( bool showing, bool hiding );

    string OffcanvasVisible( bool visible );

    string OffcanvasHeader();

    string OffcanvasFooter();

    string OffcanvasBody();

    string OffcanvasBackdrop();

    string OffcanvasBackdropFade( bool showing, bool hiding );

    string OffcanvasBackdropVisible( bool visible );

    #endregion

    #region Toast

    string Toast();

    string ToastAnimated( bool animated );

    string ToastFade( bool visible, bool showing, bool hiding );

    string ToastVisible( bool visible );

    string ToastHeader();

    string ToastBody();

    string Toaster();

    string ToasterPlacement( ToasterPlacement placement );

    string ToasterPlacementStrategy( ToasterPlacementStrategy placementStrategy );

    #endregion

    #region Pagination

    string Pagination();

    string PaginationSize( Size size );

    string PaginationAlignment( Alignment alignment );

    string PaginationBackgroundColor( Background background );

    string PaginationItem();

    string PaginationItemActive( bool active );

    string PaginationItemDisabled( bool disabled );

    string PaginationLink();

    string PaginationLinkSize( Size size );

    string PaginationLinkActive( bool active );

    string PaginationLinkDisabled( bool disabled );

    #endregion

    #region Progress

    string Progress();

    string ProgressSize( Size size );

    string ProgressColor( Color color );

    string ProgressStriped( bool stripped );

    string ProgressAnimated( bool animated );

    string ProgressIndeterminate( bool indeterminate );

    string ProgressWidth( int width );

    string ProgressBar();

    string ProgressBarSize( Size size );

    string ProgressBarColor( Color color );

    string ProgressBarStriped( bool striped );

    string ProgressBarAnimated( bool animated );

    string ProgressBarIndeterminate( bool indeterminate );

    string ProgressBarWidth( int width );

    #endregion

    #region Chart

    string Chart();

    #endregion

    #region Colors

    string BackgroundColor( Background background );

    #endregion

    #region Table

    string Table();

    string TableFullWidth( bool fullWidth );

    string TableStriped( bool striped );

    string TableHoverable( bool hoverable );

    string TableBordered( bool bordered );

    string TableNarrow( bool narrow );

    string TableBorderless( bool borderless );

    string TableHeader();

    string TableHeaderThemeContrast( ThemeContrast themeContrast );

    string TableHeaderCell();

    string TableHeaderCellCursor( Cursor cursor );

    string TableHeaderCellFixed( TableColumnFixedPosition fixedPosition );

    string TableFooter();

    string TableBody();

    string TableRow( bool striped, bool hoverable );

    string TableRowColor( Color color );

    string TableRowHoverCursor( Cursor cursor );

    string TableRowIsSelected( bool selected );

    string TableRowHeader();

    string TableRowHeaderFixed( TableColumnFixedPosition fixedPosition );

    string TableRowCell();

    string TableRowCellColor( Color color );

    string TableRowCellFixed( TableColumnFixedPosition fixedPosition );

    string TableRowGroup( bool expanded );

    string TableRowGroupCell();

    string TableRowGroupIndentCell();

    string TableResponsive( bool responsive );

    string TableFixedHeader( bool fixedHeader );

    string TableFixedColumns( bool fixedColumns );

    string TableResponsiveMode( TableResponsiveMode responsiveMode );

    string TableCaption();

    string TableCaptionSide( TableCaptionSide side );

    #endregion

    #region Badge

    string Badge();

    string BadgeColor( Color color );

    string BadgePill( bool pill );

    string BadgeClose();

    string BadgeCloseColor( Color color );

    #endregion

    #region Media

    string Media();

    string MediaLeft();

    string MediaRight();

    string MediaBody();

    #endregion

    #region Text

    string TextColor( TextColor textColor );

    string TextAlignment( TextAlignment textAlignment );

    string TextTransform( TextTransform textTransform );

    string TextDecoration( TextDecoration textDecoration );

    string TextWeight( TextWeight textWeight );

    string TextOverflow( TextOverflow textOverflow );

    string TextSize( TextSizeType textSizeType, TextSizeDefinition textSizeDefinition );

    string TextItalic( bool italic );

    #endregion

    #region Code

    string Code();

    #endregion

    #region Heading

    string HeadingSize( HeadingSize headingSize );

    #endregion

    #region DisplayHeading

    string DisplayHeadingSize( DisplayHeadingSize displayHeadingSize );

    #endregion

    #region Lead

    string Lead();

    #endregion

    #region Paragraph

    string Paragraph();

    string ParagraphColor( TextColor textColor );

    #endregion

    #region Blockquote

    string Blockquote();

    string BlockquoteFooter();

    #endregion

    #region Figure

    string Figure();

    string FigureSize( FigureSize figureSize );

    string FigureImage();

    string FigureImageRounded( bool rounded );

    string FigureCaption();

    #endregion

    #region Image

    string Image();

    string ImageFluid( bool fluid );

    #endregion

    #region Breadcrumb

    string Breadcrumb();

    string BreadcrumbItem();

    string BreadcrumbItemActive( bool active );

    string BreadcrumbLink();

    #endregion

    #region Tooltip

    string Tooltip();

    string TooltipPlacement( TooltipPlacement tooltipPlacement );

    string TooltipMultiline( bool multiline );

    string TooltipAlwaysActive( bool alwaysActive );

    string TooltipFade( bool fade );

    string TooltipInline( bool inline );

    #endregion

    #region Skeleton

    string Skeleton();

    string SkeletonAnimation( SkeletonAnimation animation );

    string SkeletonItem();

    #endregion

    #region Divider

    string Divider();

    string DividerType( DividerType dividerType );

    #endregion

    #region Link

    string Link();

    string LinkActive( bool active );

    string LinkUnstyled( bool unstyled );

    string LinkStretched( bool stretched );

    string LinkDisabled( bool disabled );

    #endregion

    #region States

    string Show();

    string Fade();

    string Active();

    string Disabled();

    string Collapsed();

    #endregion

    #region Layout

    string Spacing( Spacing spacing, SpacingSize spacingSize, Side side, Breakpoint breakpoint );

    string Spacing( Spacing spacing, SpacingSize spacingSize, IEnumerable<(Side side, Breakpoint breakpoint)> rules );

    #endregion

    #region Gap

    string Gap( GapSize gapSize, GapSide gapSide );

    string Gap( GapSize gapSize, IEnumerable<GapSide> rules );

    #endregion

    #region Borders

    string Border( BorderSize borderSize, BorderSide borderSide, BorderColor borderColor );

    string Border( BorderSize borderSize, IEnumerable<(BorderSide borderSide, BorderColor borderColor)> rules );

    string BorderRadius( BorderRadius borderRadius );

    #endregion

    #region Flex

    string Flex( FlexType flexType );

    string Flex( FlexDefinition flexDefinition );

    string Flex( FlexRule flexRule );

    #endregion

    #region Sizing

    string Sizing( SizingType sizingType, SizingSize sizingSize, SizingDefinition sizingDefinition );

    string Sizing( SizingType sizingType, SizingSize sizingSize, IEnumerable<SizingDefinition> rules );

    #endregion

    #region Float

    string Float( Float @float );

    string Clearfix();

    #endregion

    #region Visibility

    string Visibility( Visibility visibility );

    #endregion

    #region VerticalAlignment

    string VerticalAlignment( VerticalAlignment verticalAlignment );

    #endregion

    #region Shadow

    string Shadow( Shadow shadow );

    #endregion

    #region Overflow

    string Overflow( OverflowType overflowType, OverflowType secondOverflowType );

    #endregion

    #region Position

    string Position( PositionType positionType, PositionEdgeType edgeType, int edgeOffset, PositionTranslateType translateType );

    string Position( PositionType positionType, IEnumerable<(PositionEdgeType edgeType, int edgeOffset)> edges, PositionTranslateType translateType );

    #endregion

    #region ObjectFit

    string ObjectFit( ObjectFitType objectFitType, ObjectFitDefinition objectFitDefinition );

    #endregion

    #region Custom

    string Casing( CharacterCasing characterCasing );

    #endregion

    #region Elements

    string UnorderedList();

    string UnorderedListUnstyled( bool unstyled );

    string OrderedList();

    string OrderedListUnstyled( bool unstyled );

    string OrderedListType( OrderedListType orderedListType );

    string DescriptionList();

    string DescriptionListTerm();

    string DescriptionListDefinition();

    #endregion

    #region Enums

    /* 
     * These methods are named with "To" prefix to indicate they're used only to convert en enum to the equivalent
     * keyword in the implementation class provider.
     */

    string ToSize( Size size );

    string ToBreakpoint( Breakpoint breakpoint );

    string ToColor( Color color );

    string ToBackground( Background background );

    string ToTextColor( TextColor textColor );

    string ToThemeContrast( ThemeContrast themeContrast );

    string ToFloat( Float @float );

    string ToBorderRadius( BorderRadius borderRadius );

    string ToSpacing( Spacing spacing );

    string ToSide( Side side );

    string ToAlignment( Alignment alignment );

    string ToTextAlignment( TextAlignment textAlignment );

    string ToTextTransform( TextTransform textTransform );

    string ToTextWeight( TextWeight textWeight );

    string ToTextOverflow( TextOverflow textOverflow );

    string ToTextSizeType( TextSizeType textSizeType );

    string ToColumnWidth( ColumnWidth columnWidth );

    string ToDisplayType( DisplayType displayType );

    string ToDisplayDirection( DisplayDirection displayDirection );

    string ToModalSize( ModalSize modalSize );

    string ToSpacingSize( SpacingSize spacingSize );

    string ToGapSize( GapSize gapSize );

    string ToJustifyContent( JustifyContent justifyContent );

    string ToJustifyContent( FlexJustifyContent justifyContent );

    string ToScreenreader( Screenreader screenreader );

    string ToHeadingSize( HeadingSize headingSize );

    string ToDisplayHeadingSize( DisplayHeadingSize displayHeadingSize );

    string ToJumbotronTitleSize( JumbotronTitleSize jumbotronTitleSize );

    string ToPlacement( Placement placement );

    string ToTooltipPlacement( TooltipPlacement tooltipPlacement );

    string ToFigureSize( FigureSize figureSize );

    string ToCharacterCasing( CharacterCasing characterCasing );

    string ToBarMode( BarMode mode );

    string ToBarCollapsedMode( BarCollapseMode collapseMode );

    string ToDirection( FlexDirection direction );

    string ToAlignItems( FlexAlignItems alignItems );

    string ToAlignSelf( FlexAlignSelf alignSelf );

    string ToAlignContent( FlexAlignContent alignContent );

    string ToGrowShrink( FlexGrowShrink growShrink );

    string ToGrowShrinkSize( FlexGrowShrinkSize growShrinkSize );

    string ToWrap( FlexWrap wrap );

    string ToOrder( FlexOrder order );

    string ToSizingType( SizingType sizingType );

    string ToSizingSize( SizingSize sizingSize );

    string ToVerticalAlignment( VerticalAlignment verticalAlignment );

    string ToShadow( Shadow shadow );

    string ToOrderedListType( OrderedListType orderedListType );

    string ToPositionType( PositionType positionType );

    string ToPositionEdgeType( PositionEdgeType positionEdgeType );

    string ToPositionTranslateType( PositionTranslateType positionTranslateType );

    string ToTableColumnFixedPosition( TableColumnFixedPosition tableColumnFixedPosition );

    string ToObjectFitType( ObjectFitType objectFitType );

    string ToSkeletonAnimation( SkeletonAnimation animation );

    string ToTableCaptionSide( TableCaptionSide side );

    #endregion

    #region Extensions

    #region Autocomplete

    string AutocompleteItemFocus( bool focus );

    #endregion

    #endregion

    /// <summary>
    /// Enables a custom css for select/check/radio/file inputs.
    /// </summary>
    bool UseCustomInputStyles { get; set; }

    /// <summary>
    /// Gets the provider implementation name.
    /// </summary>
    string Provider { get; }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member