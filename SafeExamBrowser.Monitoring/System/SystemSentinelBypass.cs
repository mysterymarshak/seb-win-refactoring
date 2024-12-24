using SafeExamBrowser.Logging.Contracts;
using SafeExamBrowser.Monitoring.Contracts.System;
using SafeExamBrowser.Monitoring.Contracts.System.Events;
using SafeExamBrowser.Monitoring.System.Components;
using SafeExamBrowser.SystemComponents.Contracts.Registry;
using SafeExamBrowser.WindowsApi.Contracts;

namespace SafeExamBrowser.Monitoring.System
{
	public class SystemSentinelBypass : ISystemSentinel
	{
		private readonly CursorsBypass cursors;
		private readonly EaseOfAccess easeOfAccess;
		private readonly StickyKeysBypass stickyKeys;
		private readonly SystemEvents systemEvents;

		public event SentinelEventHandler CursorChanged;
		public event SentinelEventHandler EaseOfAccessChanged;
		public event SentinelEventHandler StickyKeysChanged;
		public event SessionChangedEventHandler SessionChanged;

		public SystemSentinelBypass(ILogger logger, INativeMethods nativeMethods, IRegistry registry)
		{
			cursors = new CursorsBypass(logger, registry);
			easeOfAccess = new EaseOfAccess(logger, registry);
			stickyKeys = new StickyKeysBypass(logger, nativeMethods);
			systemEvents = new SystemEvents(logger);
		}

		public bool DisableStickyKeys()
		{
			return stickyKeys.Disable();
		}

		public bool EnableStickyKeys()
		{
			return stickyKeys.Enable();
		}

		public bool RevertStickyKeys()
		{
			return stickyKeys.Revert();
		}

		public void StartMonitoringCursors()
		{
			cursors.CursorChanged += (args) => CursorChanged?.Invoke(args);
			cursors.StartMonitoring();
		}

		public void StartMonitoringEaseOfAccess()
		{
			easeOfAccess.EaseOfAccessChanged += (args) => EaseOfAccessChanged?.Invoke(args);
			easeOfAccess.StartMonitoring();
		}

		public void StartMonitoringStickyKeys()
		{
			stickyKeys.Changed += (args) => StickyKeysChanged?.Invoke(args);
			stickyKeys.StartMonitoring();
		}

		public void StartMonitoringSystemEvents()
		{
			systemEvents.SessionChanged += () => SessionChanged?.Invoke();
			systemEvents.StartMonitoring();
		}

		public void StopMonitoring()
		{
			cursors.StopMonitoring();
			easeOfAccess.StopMonitoring();
			stickyKeys.StopMonitoring();
			systemEvents.StopMonitoring();
		}

		public bool VerifyCursors()
		{
			return cursors.Verify();
		}

		public bool VerifyEaseOfAccess()
		{
			return easeOfAccess.Verify();
		}
	}
}
