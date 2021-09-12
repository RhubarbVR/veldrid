namespace Veldrid
{
    /// <summary>
    /// Window State represents what scale or if window has border
    /// </summary>
    public enum WindowState
    {
        /// <summary>
        /// Normal is when the size is whatever and there is a boarder
        /// </summary>
        Normal,
        /// <summary>
        /// FullScreen is when the size is the size of the screen and there is a boarder that can't be seen
        /// </summary>
        FullScreen,
        /// <summary>
        /// Maximized is when the size is the size of the screen and there is a boarder can be seen
        /// </summary>
        Maximized,
        /// <summary>
        /// Minimized is when nothing can be seen as running in dock or taskbar
        /// </summary>
        Minimized,
        /// <summary>
        /// FullScreen is when the size is the size of the screen and there is no boader at all
        /// </summary>
        BorderlessFullScreen,
        /// <summary>
        /// Hidden is when nothing can be seen at all
        /// </summary>
        Hidden,
    }
}
