using System;
using System.Runtime.InteropServices;

namespace Veldrid.Sdl2
{
    public static unsafe partial class Sdl2Native
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int SDL_Init_t(SDLInitFlags flags);
        private static SDL_Init_t s_sdl_init = LoadFunction<SDL_Init_t>("SDL_Init");
        /// <summary>
        /// Int Sdl2Native with flags
        /// </summary>
        /// <param name="flags"></param>
        /// <returns></returns>
        public static int SDL_Init(SDLInitFlags flags) => s_sdl_init(flags);
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum SDLInitFlags : uint
    {
        Timer = 0x00000001u,
        Audio = 0x00000010u,
        Video = 0x00000020u,
        Joystick = 0x00000200u,
        Haptic = 0x00001000u,
        GameController = 0x00002000u,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
