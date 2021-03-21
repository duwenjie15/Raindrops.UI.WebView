using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Raindrops.Builder.Hook
{
    public class VirtualProtectChanger_Win
    {
        [DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
        public static extern bool VirtualProtectWin(IntPtr lpAddress, int dwSize, MemoryProtectionConstants flNewProtect, out MemoryProtectionConstants lpflOldProtect);
        public static bool VirtualProtect(IntPtr baseAddress, int size, MemoryProtectionConstants newProtectionType, out MemoryProtectionConstants oldProtectionType)
        {
            var result = VirtualProtectWin(baseAddress, size, newProtectionType, out var obj);
            oldProtectionType = obj;
            return result;
        }
    }
}
