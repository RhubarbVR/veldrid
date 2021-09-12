using System;

namespace Veldrid.Sdl2
{
    /// <summary>
    /// A transparent wrapper over a pointer representing an SDL Renderer object.
    /// </summary>
    public struct SDL_Renderer
    {
        /// <summary>
        /// The native SDL_Renderer pointer.
        /// </summary>
        public readonly IntPtr NativePointer;
        /// <summary>
        /// SDL Renderer
        /// </summary>
        /// <param name="pointer">The pointer to the renderer</param>
        public SDL_Renderer(IntPtr pointer)
        {
            NativePointer = pointer;
        }
        /// <summary>
        /// Cast to IntPtr
        /// </summary>
        /// <param name="Sdl2Window">SDL_Renderer</param>
        /// <returns>Renderer Pointer</returns>
        public static implicit operator IntPtr(SDL_Renderer Sdl2Window) => Sdl2Window.NativePointer;
        /// <summary>
        /// Cast to SDL_Renderer
        /// </summary>
        /// <param name="pointer">Pointer to SDL_Renderer</param>
        /// <returns>SDL_Renderer</returns>
        public static implicit operator SDL_Renderer(IntPtr pointer) => new SDL_Renderer(pointer);
    }
}
