using System.Collections.Generic;
using System.Numerics;

namespace Veldrid
{
    /// <summary>
    /// A snapshot of the keyboard and mouse input
    /// </summary>
    public interface InputSnapshot
    {
        /// <summary>
        /// A list of every keyboard key that has been pressed or has been released
        /// </summary>
        IReadOnlyList<KeyEvent> KeyEvents { get; }
        /// <summary>
        /// A list of every mouse buttons that has been pressed or has been released
        /// </summary>
        IReadOnlyList<MouseEvent> MouseEvents { get; }
        /// <summary>
        /// A list of all of the chars pressed at this frame
        /// </summary>
        IReadOnlyList<char> KeyCharPresses { get; }
        /// <summary>
        /// Checks if Mouse Button is down
        /// </summary>
        bool IsMouseDown(MouseButton button);
        /// <summary>
        /// Mouse postion
        /// </summary>
        Vector2 MousePosition { get; }
        /// <summary>
        /// Amount mouse wheel has moved since last frame
        /// </summary>
        float WheelDelta { get; }
    }
}
