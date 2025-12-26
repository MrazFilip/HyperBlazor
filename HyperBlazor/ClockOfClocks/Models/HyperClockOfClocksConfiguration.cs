namespace HyperBlazor.ClockOfClocks.Models
{
    /// <summary>
    /// <para>
    /// You can adjust the appearance of the clock by modifying these properties.<br/>
    /// <b>All</b> properties have default values that can be overridden as needed.
    /// </para>
    /// <para>
    /// The <c>ClockFaceBorder</c> is by default <b>TRUE</b>.<br/>
    /// The <c>CommonHandSettings</c> is by default <b>NOT NULL</b>.
    /// To customize individual hands, set the respective Hour or Minute hand property to a new instance
    /// of <see cref="ClockHandSettings"/>. If either one of the properties is null, the final hand will
    /// take shape of the <c>CommonHandSettings</c>. If no setting is provided for the <c>ClockFaceDotColor</c> and <c>ClockFaceDotColor</c>,
    /// the default will be taken first from the <c>HourHand</c>, then from the <c>MinuteHand</c>, and finally from the <c>CommonHandSettings</c>.
    /// </para>
    /// 
    /// <para>ALL PROPERTIES ARE STRINGS TO ALLOW FOR CSS UNITS (e.g., "px", "rem", "%", etc.)</para>
    /// </summary>
    public class HyperClockOfClocksConfiguration
    {
        #region Clock Setup
        /// <summary>
        /// String format used when parsing date info for the clock. Default is <c>"HH:mm:ss"</c>. To set your own format, refer to <see href="https://learn.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=net-8.0#system-datetime-tostring(system-string-system-iformatprovider)">Custom Date and Time Format Strings</see>.
        /// </summary>
        public string StringFormat { get; set; } = "HH:mm:ss";
        /// <summary>
        /// By default set to <c>NULL</c>. When set to a valid <see cref="DateTime"/>, the clock will countdown to that date and time.
        /// </summary>
        public DateTime? Countdown { get; set; }
        /// <summary>
        /// By default set to <see cref="TimeZoneOptions.Local"/>. Set to <see cref="TimeZoneOptions.Utc"/> to have the clock display UTC time.
        /// </summary>
        public TimeZoneOptions TimeZone { get; set; } = TimeZoneOptions.Local;
        /// <summary>
        /// By default set to <c>TRUE</c>. When set to <c>FALSE</c>, the clock face border will not be rendered.
        /// <para>Note: Even if set to <c>FALSE</c>, the <c>ClockFaceBorderRadius</c> is <b>still applied</b>.</para>
        /// </summary>
        public bool ClockFaceBorder { get; set; } = true;
        public string? SeparatorColor { get; set; } = null!;
        #endregion
        #region Clock Face
        public string ClockFaceColor { get; set; } = "white";
        #endregion
        #region Clock Face Border
        public string ClockFaceBorderColor { get; set; } = "#222222";
        public string ClockFaceBorderWidth { get; set; } = "6.25%";
        public string ClockFaceBorderRadius { get; set; } = "50%";
        public string ClockFaceBorderStyle { get; set; } = "solid";
        #endregion
        #region Clock Hands
        public ClockHandSettings CommonHandSettings = new();
        public ClockHandSettings? HourHand;
        public ClockHandSettings? MinuteHand;
        #endregion
        #region Clock Dot
        public string? ClockFaceDotColor { get; set; } = null!;
        public string? ClockFaceDotWidth { get; set; } = null!;
        public string ClockFaceDotRadius { get; set; } = "50%";
        #endregion
    }

    public class ClockHandSettings
    {
        public string Color { get; set; } = "black";
        public string Width { get; set; } = "6.25%";
        public string Lenght { get; set; } = "50%";
        public string Speed { get; set; } = "250ms";
    }

    public enum TimeZoneOptions
    {
        Local,
        Utc
    }
}
