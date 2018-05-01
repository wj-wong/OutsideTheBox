﻿namespace OTB.Core.Hook.Platform.OSX.Native
{
    public static class MacOSKeyMap
    {
        public static Key GetKey(MacOSKeyCode code)
        {
            // comments indicate members of the Key enum that are missing
            switch (code)
            {
                case MacOSKeyCode.A:
                    return Key.A;
                case MacOSKeyCode.OptionAlt:
                    return Key.AltLeft;
                case MacOSKeyCode.OptionAltR:
                    return Key.AltRight;
                case MacOSKeyCode.B:
                    return Key.B;
                case MacOSKeyCode.Backslash:
                    return Key.BackSlash;
                case MacOSKeyCode.Backspace:
                    return Key.BackSpace;
                case MacOSKeyCode.BracketLeft:
                    return Key.BracketLeft;
                case MacOSKeyCode.BracketRight:
                    return Key.BracketRight;
                case MacOSKeyCode.C:
                    return Key.C;
                // Capslock
                // Clear
                case MacOSKeyCode.Comma:
                    return Key.Comma;
                case MacOSKeyCode.Control:
                    return Key.ControlLeft;
                // ControlRight
                case MacOSKeyCode.D:
                    return Key.D;
                case MacOSKeyCode.Del:
                    return Key.Delete;
                case MacOSKeyCode.Down:
                    return Key.Down;
                case MacOSKeyCode.E:
                    return Key.E;
                case MacOSKeyCode.End:
                    return Key.End;
                case MacOSKeyCode.Enter:
                    return Key.Enter;
                case MacOSKeyCode.Return:
                    return Key.Enter;
                case MacOSKeyCode.Esc:
                    return Key.Escape;
                case MacOSKeyCode.F:
                    return Key.F;
                case MacOSKeyCode.F1:
                    return Key.F1;
                case MacOSKeyCode.F2:
                    return Key.F2;
                case MacOSKeyCode.F3:
                    return Key.F3;
                case MacOSKeyCode.F4:
                    return Key.F4;
                case MacOSKeyCode.F5:
                    return Key.F5;
                case MacOSKeyCode.F6:
                    return Key.F6;
                case MacOSKeyCode.F7:
                    return Key.F7;
                case MacOSKeyCode.F8:
                    return Key.F8;
                case MacOSKeyCode.F9:
                    return Key.F9;
                case MacOSKeyCode.F10:
                    return Key.F10;
                case MacOSKeyCode.F11:
                    return Key.F11;
                case MacOSKeyCode.F12:
                    return Key.F12;
                case MacOSKeyCode.F13:
                    return Key.F13;
                case MacOSKeyCode.F14:
                    return Key.F14;
                case MacOSKeyCode.F15:
                    return Key.F15;
                // F16-F35
                case MacOSKeyCode.G:
                    return Key.G;
                case MacOSKeyCode.H:
                    return Key.H;
                case MacOSKeyCode.Home:
                    return Key.Home;
                case MacOSKeyCode.I:
                    return Key.I;
                case MacOSKeyCode.Insert:
                    return Key.Insert;
                case MacOSKeyCode.J:
                    return Key.J;
                case MacOSKeyCode.K:
                    return Key.K;
                case MacOSKeyCode.KeyPad_0:
                    return Key.Keypad0;
                case MacOSKeyCode.KeyPad_1:
                    return Key.Keypad1;
                case MacOSKeyCode.KeyPad_2:
                    return Key.Keypad2;
                case MacOSKeyCode.KeyPad_3:
                    return Key.Keypad3;
                case MacOSKeyCode.KeyPad_4:
                    return Key.Keypad4;
                case MacOSKeyCode.KeyPad_5:
                    return Key.Keypad5;
                case MacOSKeyCode.KeyPad_6:
                    return Key.Keypad6;
                case MacOSKeyCode.KeyPad_7:
                    return Key.Keypad7;
                case MacOSKeyCode.KeyPad_8:
                    return Key.Keypad8;
                case MacOSKeyCode.KeyPad_9:
                    return Key.Keypad9;
                case MacOSKeyCode.KeyPad_Add:
                    return Key.KeypadAdd;
                case MacOSKeyCode.KeyPad_Decimal:
                    return Key.KeypadDecimal;
                case MacOSKeyCode.KeyPad_Divide:
                    return Key.KeypadDivide;
                case MacOSKeyCode.KeyPad_Enter:
                    return Key.KeypadEnter;
                case MacOSKeyCode.KeyPad_Multiply:
                    return Key.KeypadMultiply;
                case MacOSKeyCode.KeyPad_Subtract:
                    return Key.KeypadSubtract;
                //case MacOSKeyCode.KeyPad_Equal;
                case MacOSKeyCode.L:
                    return Key.L;
                case MacOSKeyCode.Left:
                    return Key.Left;
                case MacOSKeyCode.M:
                    return Key.M;
                //Key.MaxKeys
                case MacOSKeyCode.Menu:
                    return Key.Menu;
                case MacOSKeyCode.Minus:
                    return Key.Minus;
                case MacOSKeyCode.N:
                    return Key.N;
                case MacOSKeyCode.Key_0:
                    return Key.Number0;
                case MacOSKeyCode.Key_1:
                    return Key.Number1;
                case MacOSKeyCode.Key_2:
                    return Key.Number2;
                case MacOSKeyCode.Key_3:
                    return Key.Number3;
                case MacOSKeyCode.Key_4:
                    return Key.Number4;
                case MacOSKeyCode.Key_5:
                    return Key.Number5;
                case MacOSKeyCode.Key_6:
                    return Key.Number6;
                case MacOSKeyCode.Key_7:
                    return Key.Number7;
                case MacOSKeyCode.Key_8:
                    return Key.Number8;
                case MacOSKeyCode.Key_9:
                    return Key.Number9;
                // Numlock
                case MacOSKeyCode.O:
                    return Key.O;
                case MacOSKeyCode.P:
                    return Key.P;
                case MacOSKeyCode.Pagedown:
                    return Key.PageDown;
                case MacOSKeyCode.Pageup:
                    return Key.PageUp;
                // Pause
                case MacOSKeyCode.Period:
                    return Key.Period;
                case MacOSKeyCode.Equals:
                    return Key.Plus;
                // PrintScreen
                case MacOSKeyCode.Q:
                    return Key.Q;
                case MacOSKeyCode.Quote:
                    return Key.Quote;
                case MacOSKeyCode.R:
                    return Key.R;
                case MacOSKeyCode.Right:
                    return Key.Right;
                case MacOSKeyCode.S:
                    return Key.S;
                // ScrollLock
                case MacOSKeyCode.Semicolon:
                    return Key.Semicolon;
                case MacOSKeyCode.Shift:
                    return Key.ShiftLeft;
                //Key.ShiftRight
                case MacOSKeyCode.Slash:
                    return Key.Slash;
                // Key.Sleep
                case MacOSKeyCode.Space:
                    return Key.Space;
                case MacOSKeyCode.T:
                    return Key.T;
                case MacOSKeyCode.Tab:
                    return Key.Tab;
                case MacOSKeyCode.Tilde:
                    return Key.Tilde;
                case MacOSKeyCode.U:
                    return Key.U;
                case MacOSKeyCode.Up:
                    return Key.Up;
                case MacOSKeyCode.V:
                    return Key.V;
                case MacOSKeyCode.W:
                    return Key.W;
                case MacOSKeyCode.Command:
                    return Key.WinLeft;
                case MacOSKeyCode.CommandR:
                    return Key.WinRight;
                case MacOSKeyCode.Fn:
                    return Key.Fn;
                // WinKeyRight
                case MacOSKeyCode.X:
                    return Key.X;
                case MacOSKeyCode.Y:
                    return Key.Y;
                case MacOSKeyCode.Z:
                    return Key.Z;

                default:
                    return Key.Unknown;
            }
        }
        
        public static MacOSKeyCode GetKey(Key code)
        {
            // comments indicate members of the Key enum that are missing
            switch (code)
            {
                case Key.A:
                    return MacOSKeyCode.A;
                case Key.AltLeft:
                    return MacOSKeyCode.OptionAlt;
                case Key.AltRight:
                    return MacOSKeyCode.OptionAltR;
                case Key.B:
                    return MacOSKeyCode.B;
                case Key.BackSlash:
                    return MacOSKeyCode.Backslash;
                case Key.BackSpace:
                    return MacOSKeyCode.Backspace;
                case Key.BracketLeft:
                    return MacOSKeyCode.BracketLeft;
                case Key.BracketRight:
                    return MacOSKeyCode.BracketRight;
                case Key.C:
                    return MacOSKeyCode.C;
                case Key.CapsLock:
                    return MacOSKeyCode.CapsLock;
                
                case Key.Comma:
                    return MacOSKeyCode.Comma;
                case Key.ControlLeft:
                    return MacOSKeyCode.Control;
                case Key.ControlRight:
                    return MacOSKeyCode.Control;
          
                case Key.D:
                    return MacOSKeyCode.D;
                case Key.Delete:
                    return MacOSKeyCode.Del;
                case Key.Down:
                    return MacOSKeyCode.Down;
                case Key.E:
                    return MacOSKeyCode.E;
                case Key.End:
                    return MacOSKeyCode.End;
                case Key.Enter:
                    return MacOSKeyCode.Enter;
                 
                case Key.Escape:
                    return MacOSKeyCode.Esc;
                case Key.F:
                    return MacOSKeyCode.F;
                case Key.F1:
                    return MacOSKeyCode.F1;
                case Key.F2:
                    return MacOSKeyCode.F2;
                case Key.F3:
                    return MacOSKeyCode.F3;
                case Key.F4:
                    return MacOSKeyCode.F4;
                case Key.F5:
                    return MacOSKeyCode.F5;
                case Key.F6:
                    return MacOSKeyCode.F6;
                case Key.F7:
                    return MacOSKeyCode.F7;
                case Key.F8:
                    return MacOSKeyCode.F8;
                case Key.F9:
                    return MacOSKeyCode.F9;
                case Key.F10:
                    return MacOSKeyCode.F10;
                case Key.F11:
                    return MacOSKeyCode.F11;
                case Key.F12:
                    return MacOSKeyCode.F12;
                case Key.F13:
                    return MacOSKeyCode.F13;
                case Key.F14:
                    return MacOSKeyCode.F14;
                case Key.F15:
                    return MacOSKeyCode.F15;
                // F16-F35
                case Key.G:
                    return MacOSKeyCode.G;
                case Key.H:
                    return MacOSKeyCode.H;
                case Key.Home:
                    return MacOSKeyCode.Home;
                case Key.I:
                    return MacOSKeyCode.I;
                case Key.Insert:
                    return MacOSKeyCode.Insert;
                case Key.J:
                    return MacOSKeyCode.J;
                case Key.K:
                    return MacOSKeyCode.K;
                case Key.Keypad0:
                    return MacOSKeyCode.KeyPad_0;
                case Key.Keypad1:
                    return MacOSKeyCode.KeyPad_1;
                case Key.Keypad2:
                    return MacOSKeyCode.KeyPad_2;
                case Key.Keypad3:
                    return MacOSKeyCode.KeyPad_3;
                case Key.Keypad4:
                    return MacOSKeyCode.KeyPad_4;
                case Key.Keypad5:
                    return MacOSKeyCode.KeyPad_5;
                case Key.Keypad6:
                    return MacOSKeyCode.KeyPad_6;
                case Key.Keypad7:
                    return MacOSKeyCode.KeyPad_7;
                case Key.Keypad8:
                    return MacOSKeyCode.KeyPad_8;
                case Key.Keypad9:
                    return MacOSKeyCode.KeyPad_9;
                case Key.KeypadAdd:
                    return MacOSKeyCode.KeyPad_Add;
                case Key.KeypadDecimal:
                    return MacOSKeyCode.KeyPad_Decimal;
                case Key.KeypadDivide:
                    return MacOSKeyCode.KeyPad_Divide;
                case Key.KeypadEnter:
                    return MacOSKeyCode.KeyPad_Enter;
                case Key.KeypadMultiply:
                    return MacOSKeyCode.KeyPad_Multiply;
                case Key.KeypadSubtract:
                    return MacOSKeyCode.KeyPad_Subtract;
                //case Key.KeyPad_Equal;
                 
                case Key.L:
                    return MacOSKeyCode.L;
                case Key.Left:
                    return MacOSKeyCode.Left;
                case Key.M:
                    return MacOSKeyCode.M;
                //MacOSKeyCode.MaxKeys
                case Key.Menu:
                    return MacOSKeyCode.Menu;
                case Key.Minus:
                    return MacOSKeyCode.Minus;
                case Key.N:
                    return MacOSKeyCode.N;
                case Key.Number0:
                    return MacOSKeyCode.Key_0;
                case Key.Number1:
                    return MacOSKeyCode.Key_1;
                case Key.Number2:
                    return MacOSKeyCode.Key_2;
                case Key.Number3:
                    return MacOSKeyCode.Key_3;
                case Key.Number4:
                    return MacOSKeyCode.Key_4;
                case Key.Number5:
                    return MacOSKeyCode.Key_5;
                case Key.Number6:
                    return MacOSKeyCode.Key_6;
                case Key.Number7:
                    return MacOSKeyCode.Key_7;
                case Key.Number8:
                    return MacOSKeyCode.Key_8;
                case Key.Number9:
                    return MacOSKeyCode.Key_9;
                // Numlock
                case Key.O:
                    return MacOSKeyCode.O;
                case Key.P:
                    return MacOSKeyCode.P;
                case Key.PageDown:
                    return MacOSKeyCode.Pagedown;
                case Key.PageUp:
                    return MacOSKeyCode.Pageup;
                // Pause
                case Key.Period:
                    return MacOSKeyCode.Period;
                case Key.Plus:
                    return MacOSKeyCode.Equals;
                // PrintScreen
                case Key.Q:
                    return MacOSKeyCode.Q;
                case Key.Quote:
                    return MacOSKeyCode.Quote;
                case Key.R:
                    return MacOSKeyCode.R;
                case Key.Right:
                    return MacOSKeyCode.Right;
                case Key.S:
                    return MacOSKeyCode.S;
                // ScrollLock
                case Key.Semicolon:
                    return MacOSKeyCode.Semicolon;
                
                case Key.ShiftLeft:
                    return MacOSKeyCode.Shift;
                case Key.ShiftRight:
                    return MacOSKeyCode.Shift;
                
                case Key.Slash:
                    return MacOSKeyCode.Slash;
                // MacOSKeyCode.Sleep
                case Key.Space:
                    return MacOSKeyCode.Space;
                case Key.T:
                    return MacOSKeyCode.T;
                case Key.Tab:
                    return MacOSKeyCode.Tab;
                case Key.Tilde:
                    return MacOSKeyCode.Tilde;
                case Key.U:
                    return MacOSKeyCode.U;
                case Key.Up:
                    return MacOSKeyCode.Up;
                case Key.V:
                    return MacOSKeyCode.V;
                case Key.W:
                    return MacOSKeyCode.W;
                case Key.WinLeft:
                    return MacOSKeyCode.Command;
                case Key.WinRight:
                    return MacOSKeyCode.CommandR;
                case Key.X:
                    return MacOSKeyCode.X;
                case Key.Y:
                    return MacOSKeyCode.Y;
                case Key.Z:
                    return MacOSKeyCode.Z;

                case Key.Fn:
                    return MacOSKeyCode.Fn;
                default:
                    return MacOSKeyCode.Unknown;
            }
        }
    }
}