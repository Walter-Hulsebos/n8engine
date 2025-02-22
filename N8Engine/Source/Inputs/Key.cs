﻿namespace N8Engine.Inputs
{
    /// <summary>
    /// A representation of a key on a keyboard.
    /// </summary>
    public enum Key
    {
        None,
        One = 0x31, Two = 0x32, Three = 0x33, Four = 0x34, Five = 0x35, Six = 0x36, Seven = 0x37, Eight = 0x38, Nine = 0x39, Zero = 0x30,
        Q = 0x51, W = 0x57, E = 0x45, R = 0x52, T = 0x54, Y = 0x59, U = 0x55, I = 0x49, O = 0x4F, P = 0x50,
        A = 0x41, S = 0x53, D = 0x44, F = 0x46, G = 0x47, H = 0x48, J = 0x4A, K = 0x4B, L = 0x4C,
        Z = 0x5A, X = 0x58, C = 0x43, V = 0x56, B = 0x42, N = 0x4E, M = 0x4D,
        LeftArrow = 0x25, RightArrow = 0x27, UpArrow = 0x26, DownArrow = 0x28, Spacebar = 0x20, Backspace = 0x08, Esc = 0x1B, Enter = 0x0D, Tab = 0x09,
        Shift = 0x10, Ctrl = 0x11, Alt = 0x12
    }
}