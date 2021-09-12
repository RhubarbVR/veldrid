using System;

namespace Veldrid.Sdl2
{
    /// <summary>
    /// A transparent wrapper over a pointer representing an SDL Sdl2Window object.
    /// </summary>
    public struct SDL_Window
    {
        /// <summary>
        /// The native SDL_Window pointer.
        /// </summary>
        public readonly IntPtr NativePointer;
        /// <summary>
        /// SDL Window
        /// </summary>
        /// <param name="pointer">The pointer to the window</param>
        public SDL_Window(IntPtr pointer)
        {
            NativePointer = pointer;
        }
        /// <summary>
        /// Cast to IntPtr
        /// </summary>
        /// <param name="Sdl2Window">window</param>
        /// <returns>Windows Pointer</returns>
        public static implicit operator IntPtr(SDL_Window Sdl2Window) => Sdl2Window.NativePointer;
        /// <summary>
        /// Cast to SDL_Window
        /// </summary>
        /// <param name="pointer">Pointer to SDL_Window</param>
        /// <returns>SDL_Window</returns>
        public static implicit operator SDL_Window(IntPtr pointer) => new SDL_Window(pointer);
    }
}
