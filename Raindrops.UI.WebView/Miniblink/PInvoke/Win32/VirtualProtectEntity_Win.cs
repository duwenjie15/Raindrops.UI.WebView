using System;

namespace Raindrops.Builder.Hook
{
    public class VirtualProtectEntity_Win : IDisposable
    {
        IntPtr _baseAddress;
        int _size;
        MemoryProtectionConstants _newProtectionType;
        MemoryProtectionConstants _oldProtectionType;
        public VirtualProtectEntity_Win(IntPtr baseAddress, int size, MemoryProtectionConstants newProtectionType)
        {
            _baseAddress = baseAddress;
            _size = size;
            _newProtectionType = newProtectionType;
            Init();
        }
        protected virtual void Init()
        {
            VirtualProtectChanger_Win.VirtualProtect(_baseAddress, _size, _newProtectionType, out _oldProtectionType);
        }
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                    VirtualProtectChanger_Win.VirtualProtect(_baseAddress, _size, _oldProtectionType, out _newProtectionType);
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
