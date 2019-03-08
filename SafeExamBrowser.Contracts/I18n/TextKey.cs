﻿/*
 * Copyright (c) 2019 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

namespace SafeExamBrowser.Contracts.I18n
{
	/// <summary>
	/// Defines all text elements of the user interface. Use the pattern "LogicalGroup_Description" to allow for a better overview over all
	/// keys and their usage (where applicable).
	/// </summary>
	public enum TextKey
	{
		Browser_ShowDeveloperConsole,
		BrowserWindow_ZoomMenuItem,
		LogWindow_Title,
		MessageBox_ApplicationError,
		MessageBox_ApplicationErrorTitle,
		MessageBox_ClientConfigurationError,
		MessageBox_ClientConfigurationErrorTitle,
		MessageBox_ClientConfigurationQuestion,
		MessageBox_ClientConfigurationQuestionTitle,
		MessageBox_ConfigurationDownloadError,
		MessageBox_ConfigurationDownloadErrorTitle,
		MessageBox_InvalidConfigurationData,
		MessageBox_InvalidConfigurationDataTitle,
		MessageBox_InvalidPasswordError,
		MessageBox_InvalidPasswordErrorTitle,
		MessageBox_InvalidQuitPassword,
		MessageBox_InvalidQuitPasswordTitle,
		MessageBox_NotSupportedConfigurationResource,
		MessageBox_NotSupportedConfigurationResourceTitle,
		MessageBox_Quit,
		MessageBox_QuitTitle,
		MessageBox_QuitError,
		MessageBox_QuitErrorTitle,
		MessageBox_ReconfigurationDenied,
		MessageBox_ReconfigurationDeniedTitle,
		MessageBox_ReconfigurationError,
		MessageBox_ReconfigurationErrorTitle,
		MessageBox_ReconfigurationQuestion,
		MessageBox_ReconfigurationQuestionTitle,
		MessageBox_ReloadConfirmation,
		MessageBox_ReloadConfirmationTitle,
		MessageBox_ShutdownError,
		MessageBox_ShutdownErrorTitle,
		MessageBox_StartupError,
		MessageBox_StartupErrorTitle,
		MessageBox_UnexpectedConfigurationError,
		MessageBox_UnexpectedConfigurationErrorTitle,
		Notification_AboutTooltip,
		Notification_LogTooltip,
		OperationStatus_CloseRuntimeConnection,
		OperationStatus_EmptyClipboard,
		OperationStatus_FinalizeServiceSession,
		OperationStatus_InitializeActionCenter,
		OperationStatus_InitializeBrowser,
		OperationStatus_InitializeClient,
		OperationStatus_InitializeConfiguration,
		OperationStatus_InitializeKioskMode,
		OperationStatus_InitializeProcessMonitoring,
		OperationStatus_InitializeRuntimeConnection,
		OperationStatus_InitializeServiceSession,
		OperationStatus_InitializeTaskbar,
		OperationStatus_InitializeWindowMonitoring,
		OperationStatus_InitializeWorkingArea,
		OperationStatus_RestartCommunicationHost,
		OperationStatus_RestoreWorkingArea,
		OperationStatus_RevertKioskMode,
		OperationStatus_StartClient,
		OperationStatus_StartCommunicationHost,
		OperationStatus_StartKeyboardInterception,
		OperationStatus_StartMouseInterception,
		OperationStatus_InitializeSession,
		OperationStatus_StopClient,
		OperationStatus_StopCommunicationHost,
		OperationStatus_StopKeyboardInterception,
		OperationStatus_StopMouseInterception,
		OperationStatus_StopProcessMonitoring,
		OperationStatus_StopWindowMonitoring,
		OperationStatus_TerminateActionCenter,
		OperationStatus_TerminateBrowser,
		OperationStatus_TerminateTaskbar,
		OperationStatus_WaitExplorerStartup,
		OperationStatus_WaitExplorerTermination,
		OperationStatus_WaitRuntimeDisconnection,
		PasswordDialog_Cancel,
		PasswordDialog_Confirm,
		PasswordDialog_LocalAdminPasswordRequired,
		PasswordDialog_LocalAdminPasswordRequiredTitle,
		PasswordDialog_LocalSettingsPasswordRequired,
		PasswordDialog_LocalSettingsPasswordRequiredTitle,
		PasswordDialog_QuitPasswordRequired,
		PasswordDialog_QuitPasswordRequiredTitle,
		PasswordDialog_SettingsPasswordRequired,
		PasswordDialog_SettingsPasswordRequiredTitle,
		RuntimeWindow_ApplicationRunning,
		SystemControl_BatteryCharged,
		SystemControl_BatteryCharging,
		SystemControl_BatteryChargeCriticalWarning,
		SystemControl_BatteryChargeLowInfo,
		SystemControl_BatteryRemainingCharge,
		SystemControl_KeyboardLayoutTooltip,
		SystemControl_WirelessConnected,
		SystemControl_WirelessDisconnected,
		SystemControl_WirelessNotAvailable,
		Version
	}
}
