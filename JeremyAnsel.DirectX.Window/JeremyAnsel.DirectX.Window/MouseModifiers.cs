// <copyright file="MouseModifiers.cs" company="Jérémy Ansel">
// Copyright (c) 2015-2026 Jérémy Ansel
// </copyright>

namespace JeremyAnsel.DirectX.Window
{
    [Flags]
    public enum MouseModifiers
    {
        /// <summary>
        /// None.
        /// </summary>
        None,

        /// <summary>
        /// The left mouse button is down.
        /// </summary>
        LeftButton = 0x01,

        /// <summary>
        /// The right mouse button is down.
        /// </summary>
        RightButton = 0x02,

        /// <summary>
        /// The SHIFT key is down.
        /// </summary>
        ShiftKey = 0x04,

        /// <summary>
        /// The CTRL key is down.
        /// </summary>
        ControlKey = 0x08,

        /// <summary>
        /// The middle mouse button is down.
        /// </summary>
        MiddleButton = 0x10,

        /// <summary>
        /// The XBUTTON1 is down.
        /// </summary>
        X1Button = 0x20,

        /// <summary>
        /// The XBUTTON2 is down.
        /// </summary>
        X2Button = 0x40,
    }
}
