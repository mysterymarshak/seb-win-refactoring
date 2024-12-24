using System.Collections.Generic;
using System.Linq;

namespace SafeExamBrowser.SystemComponents.Registry.SubKeys
{
	public class CursorRegistryKey : IMockedRegistrySubKey
	{
		private readonly Dictionary<string, object> _values = new Dictionary<string, object>
		{
			["AppStarting"] = @"C:\Windows\cursors\aero_working.ani",
			["Arrow"] = @"C:\Windows\cursors\aero_arrow.cur",
			["ContactVisualization"] = 0x00000001,
			["Crosshair"] = string.Empty,
			["CursorBaseSize"] = 0x00000020,
			["GestureVisualization"] = 0x0000001f,
			["Hand"] = @"C:\Windows\cursors\aero_link.cur",
			["Help"] = @"C:\Windows\cursors\aero_helpsel.cur",
			["IBeam"] = string.Empty,
			["No"] = @"C:\Windows\cursors\aero_unavail.cur",
			["NWPen"] = @"C:\Windows\cursors\aero_pen.cur",
			["Scheme Source"] = 0x00000002,
			["SizeAll"] = @"C:\Windows\cursors\aero_move.cur",
			["SizeNESW"] = @"C:\Windows\cursors\aero_nesw.cur",
			["SizeNS"] = @"C:\Windows\cursors\aero_ns.cur",
			["SizeNWSE"] = @"C:\Windows\cursors\aero_nwse.cur",
			["SizeWE"] = @"C:\Windows\cursors\aero_ew.cur",
			["UpArrow"] = @"C:\Windows\cursors\aero_up.cur",
			["Wait"] = @"C:\Windows\cursors\aero_busy.ani"
		};
		
		public object GetValue(string name, object defaultValue = null)
		{
			return !_values.TryGetValue(name, out var value) ? defaultValue : value;
		}

		public string[] GetValueNames()
		{
			return _values.Keys.ToArray();
		}
	}

	public interface IMockedRegistrySubKey
	{
		object GetValue(string name, object defaultValue = null);
		string[] GetValueNames();
	}
}

/*

Windows Registry Editor Version 5.00

[HKEY_CURRENT_USER\Control Panel\Cursors]
"AppStarting"="C:\\Windows\\cursors\\aero_working.ani"
"Arrow"="C:\\Windows\\cursors\\aero_arrow.cur"
"ContactVisualization"=dword:00000001
"Crosshair"=""
"CursorBaseSize"=dword:00000020
"GestureVisualization"=dword:0000001f
"Hand"="C:\\Windows\\cursors\\aero_link.cur"
"Help"="C:\\Windows\\cursors\\aero_helpsel.cur"
"IBeam"=""
"No"="C:\\Windows\\cursors\\aero_unavail.cur"
"NWPen"="C:\\Windows\\cursors\\aero_pen.cur"
"Scheme Source"=dword:00000002
"SizeAll"="C:\\Windows\\cursors\\aero_move.cur"
"SizeNESW"="C:\\Windows\\cursors\\aero_nesw.cur"
"SizeNS"="C:\\Windows\\cursors\\aero_ns.cur"
"SizeNWSE"="C:\\Windows\\cursors\\aero_nwse.cur"
"SizeWE"="C:\\Windows\\cursors\\aero_ew.cur"
"UpArrow"="C:\\Windows\\cursors\\aero_up.cur"
"Wait"="C:\\Windows\\cursors\\aero_busy.ani"
@="По умолчанию"

*/