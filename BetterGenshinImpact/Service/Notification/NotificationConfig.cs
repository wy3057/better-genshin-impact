using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace BetterGenshinImpact.Service.Notification;

/// <summary>
///     Notification
/// </summary>
[Serializable]
public partial class NotificationConfig : ObservableObject
{
    [ObservableProperty]
    private string _notificationEventSubscribe = string.Empty;

    [ObservableProperty]
    private bool _webhookEnabled;

    [ObservableProperty]
    private string _webhookEndpoint = string.Empty;

    [ObservableProperty]
    private bool _includeScreenShot = true;

    [ObservableProperty]
    private bool _windowsUwpNotificationEnabled = false;

    [ObservableProperty]
    private bool _feishuNotificationEnabled = false;

    [ObservableProperty]
    private string _feishuWebhookUrl = string.Empty;

    [ObservableProperty]
    private bool _workweixinNotificationEnabled = false;

    [ObservableProperty]
    private string _workweixinWebhookUrl = string.Empty;

    // WebSocket 通知
    [ObservableProperty]
    private bool _webSocketNotificationEnabled = false;

    [ObservableProperty]
    private string _webSocketEndpoint = string.Empty;
}