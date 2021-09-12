namespace Veldrid.Sdl2
{
    /// <summary>
    /// Event for when a file is droped onto window
    /// </summary>
    public struct DragDropEvent
    {
        /// <summary>
        /// The path to the file
        /// </summary>
        public string File { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file">The path to the file</param>
        public DragDropEvent(string file)
        {
            File = file;
        }
    }
}
