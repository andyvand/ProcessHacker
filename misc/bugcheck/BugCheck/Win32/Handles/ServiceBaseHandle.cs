﻿/*
 * Process Hacker - 
 *   service-related handle
 * 
 * Copyright (C) 2008 wj32
 * 
 * This file is part of Process Hacker.
 * 
 * Process Hacker is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * Process Hacker is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with Process Hacker.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Runtime.InteropServices;

namespace ProcessHacker
{
    public partial class Win32
    {
        /// <summary>
        /// Represents a handle managed by the Windows service manager.
        /// </summary>
        public class ServiceBaseHandle : Win32Handle
        {
            public ServiceBaseHandle(int Handle, bool Owned)
                : base(Handle, Owned)
            { }

            protected ServiceBaseHandle()
            { }

            protected override void Close()
            {
                CloseServiceHandle(this.Handle);
            }
        }
    }
}
