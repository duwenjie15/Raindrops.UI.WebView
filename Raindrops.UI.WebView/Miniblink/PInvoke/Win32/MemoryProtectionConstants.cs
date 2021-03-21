using System;

namespace Raindrops.Builder.Hook
{
    public enum MemoryProtectionConstants : UInt32
    {
        /// <summary>
        /// 启用对页的已提交区域的执行访问权限,尝试写入已提交的区域会导致访问冲突
        /// </summary>
        PAGE_EXECUTE = 0x10,
        /// <summary>
        /// 启用对页的已提交区域的执行或只读访问,尝试写入已提交的区域会导致访问冲突
        /// (Nonsupport:Windows Xp with SP1 or Windows server 2003 on CreateFileMapping functions)
        /// </summary>
        PAGE_EXECUTE_READ = 0x20,
        /// <summary>
        /// 对已提交的页区域启用执行、只读或读/写访问权限
        /// (Nonsupport:Windows Xp with SP1 or Windows server 2003 on CreateFileMapping functions)
        /// </summary>
        PAGE_EXECUTE_READWRITE = 0x40,
        /// <summary>
        /// 启用对文件映射对象的映射视图执行、只读或复制对写访问.尝试写入已提交的"写入时复制"页将导致为进程生成的页的专用副本.专用页标记为PAGE_EXECUTE_READWRITE,更改将写入新页 (Nonsupport:VirtualAlloc and VirtualAllocEx function,Windows Xp 、 Windows server 2003 or Windows Vista on CreateFileMapping functions)
        /// </summary>
        PAGE_EXECUTE_WRITECOPY = 0x80,
        /// <summary>
        /// 禁用对页的提交区域的所有访问,尝试读取、写入或执行提交的区域会导致访问冲突
        /// </summary>
        PAGE_NOACCESS = 0x01,
        /// <summary>
        /// 启用对页的已提交区域的只读访问,尝试写入已提交区域会导致访问冲突.如果启用了DEP,尝试在提交的区域中执行代码会导致访问冲突
        /// </summary>
        PAGE_READONLY = 0x02,
        /// <summary>
        /// 启用对页的已提交区域的只读或读/写访问.如果启用了DEP,尝试在提交的区域中执行代码会导致访问冲突
        /// </summary>
        PAGE_READWRITE = 0x04,
        /// <summary>
        /// 启用对文件映射对象的映射视图的只读或复制写入访问权限.尝试写入已提交的"写入时复制"页将导致为进程生成的页的专用副本.专用页标记为PAGE_EXECUTE_READWRITE,更改将写入新页.如果启用了数据执行预防, 尝试在提交的区域中执行代码会导致访问冲突 (Nonsupport:VirtualAlloc or VirtualAllocEx functions)
        /// </summary>
        PAGE_WRITECOPY = 0x08,
        /// <summary>
        /// 将页面中的所有位置设置为 CFG 的无效目标.与任何执行页保护一起使用
        /// (Nonsupport: VirtualProtect or CreateFileMapping functions)
        /// </summary>
        PAGE_TARGETS_INVALID = 0x40000000,
        /// <summary>
        /// 在对VirtualProtect的保护状态更改时,区域中的页不会更新其 CFG 信息,此标志仅在保护更改为包括EXECUTE类型才有效
        /// </summary>
        PAGE_TARGETS_NO_UPDATE = 0x40000000,
        /// <summary>
        /// 该区域中的页面成为保护页,保护页面充当一次性访问警报
        /// </summary>
        PAGE_GUARD = 0x100,
        /// <summary>
        /// 将所有页面设置为非缓存
        /// </summary>
        PAGE_NOCACHE = 0x200,
        /// <summary>
        /// 设置要写入组合的所有页
        /// </summary>
        PAGE_WRITECOMBINE = 0x400
    }
}
