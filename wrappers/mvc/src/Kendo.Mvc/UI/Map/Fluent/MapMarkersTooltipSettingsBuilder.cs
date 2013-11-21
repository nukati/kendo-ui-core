namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the MapMarkersTooltipSettings settings.
    /// </summary>
    public class MapMarkersTooltipSettingsBuilder: IHideObjectMembers
    {
        private readonly MapMarkersTooltipSettings container;

        public MapMarkersTooltipSettingsBuilder(MapMarkersTooltipSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// Specifies if the tooltip will be hidden when mouse leaves the target element. If set to false a close button will be shown within tooltip. If set to false, showAfter is specified and the showOn is set to "mouseenter" the Tooltip will be displayed after the given timeout even if the element is no longer hovered.
        /// </summary>
        /// <param name="value">The value that configures the autohide.</param>
        public MapMarkersTooltipSettingsBuilder AutoHide(bool value)
        {
            container.AutoHide = value;

            return this;
        }
        
        /// <summary>
        /// A collection of {Animation} objects, used to change default animations. A value of false
		/// will disable all animations in the widget.
        /// </summary>
        /// <param name="configurator">The action that configures the animation.</param>
        public MapMarkersTooltipSettingsBuilder Animation(Action<MapMarkersTooltipAnimationSettingsBuilder> configurator)
        {
            configurator(new MapMarkersTooltipAnimationSettingsBuilder(container.Animation));
            return this;
        }
        
        /// <summary>
        /// The text or a function which result will be shown within the tooltip.
		/// By default the tooltip will display the target element title attribute content.
        /// </summary>
        /// <param name="configurator">The action that configures the content.</param>
        public MapMarkersTooltipSettingsBuilder Content(Action<MapMarkersTooltipContentSettingsBuilder> configurator)
        {
            configurator(new MapMarkersTooltipContentSettingsBuilder(container.Content));
            return this;
        }
        
        /// <summary>
        /// The template which renders the tooltip content.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value that configures the templateid.</param>
        public MapMarkersTooltipSettingsBuilder TemplateId(string value)
        {
            container.TemplateId = value;

            return this;
        }
        
        /// <summary>
        /// Specifies if the tooltip callout will be displayed.
        /// </summary>
        /// <param name="value">The value that configures the callout.</param>
        public MapMarkersTooltipSettingsBuilder Callout(bool value)
        {
            container.Callout = value;

            return this;
        }
        
        /// <summary>
        /// Explicitly states whether content iframe should be created.
        /// </summary>
        /// <param name="value">The value that configures the iframe.</param>
        public MapMarkersTooltipSettingsBuilder Iframe(bool value)
        {
            container.Iframe = value;

            return this;
        }
        
        /// <summary>
        /// The height (in pixels) of the tooltip.
        /// </summary>
        /// <param name="value">The value that configures the height.</param>
        public MapMarkersTooltipSettingsBuilder Height(double value)
        {
            container.Height = value;

            return this;
        }
        
        /// <summary>
        /// The width (in pixels) of the tooltip.
        /// </summary>
        /// <param name="value">The value that configures the width.</param>
        public MapMarkersTooltipSettingsBuilder Width(double value)
        {
            container.Width = value;

            return this;
        }
        
        /// <summary>
        /// The position relative to the target element, at which the tooltip will be shown. Predefined values are "bottom", "top", "left", "right", "center".
        /// </summary>
        /// <param name="value">The value that configures the position.</param>
        public MapMarkersTooltipSettingsBuilder Position(string value)
        {
            container.Position = value;

            return this;
        }
        
        /// <summary>
        /// Specify the delay in milliseconds before the tooltip is shown. This option is ignored if showOn is set to "click" or "focus".
        /// </summary>
        /// <param name="value">The value that configures the showafter.</param>
        public MapMarkersTooltipSettingsBuilder ShowAfter(double value)
        {
            container.ShowAfter = value;

            return this;
        }
        
        /// <summary>
        /// The event on which the tooltip will be shown. Predefined values are "mouseenter", "click" and "focus".
        /// </summary>
        /// <param name="value">The value that configures the showon.</param>
        public MapMarkersTooltipSettingsBuilder ShowOn(string value)
        {
            container.ShowOn = value;

            return this;
        }
        
        //<< Fields
    }
}

