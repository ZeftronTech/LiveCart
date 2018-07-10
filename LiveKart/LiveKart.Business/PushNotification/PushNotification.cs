using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using PushSharp;
using PushSharp.Core;
using PushSharp.Apple;
using PushSharp.Android;
using LiveKart.Shared.Entities;
using LiveKart.LogService;

namespace LiveKart.Business.PushNotification
{
    public static class PushNotification
    {
        static ILogService logging = new FileLogService(typeof(PushNotification));

        public static void SendNotification(List<PushNotificationDetail> pushSettings)
        {
            if (pushSettings == null) { return; }
            //Create our push services broker
            var push = new PushBroker();

            //Wire up the events for all the services that the broker registers
            push.OnNotificationSent += NotificationSent;
            push.OnChannelException += ChannelException;
            push.OnServiceException += ServiceException;
            push.OnNotificationFailed += NotificationFailed;
            push.OnDeviceSubscriptionExpired += DeviceSubscriptionExpired;
            push.OnDeviceSubscriptionChanged += DeviceSubscriptionChanged;
            push.OnChannelCreated += ChannelCreated;
            push.OnChannelDestroyed += ChannelDestroyed;

            var appleSettings = pushSettings.Where(s => s.NotificationFor.ToLower() == "apple").ToList();
            if (appleSettings.Count > 0 && appleSettings != null)
            {
                var appleSetting = appleSettings.FirstOrDefault();

                var appleCert = File.ReadAllBytes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, appleSetting.P12CertificatePath));  
                push.RegisterAppleService(new ApplePushChannelSettings(appleCert, appleSetting.P12Password)); //Extension method
                push.QueueNotification(new AppleNotification()
                                           .ForDeviceToken(appleSetting.DeviceToken)   
                                           .WithAlert("New campaign available")
                                           .WithBadge(appleSetting.Badge)
                                           .WithSound(appleSetting.Sound));

            }
            //---------------------------
            // ANDROID GCM NOTIFICATIONS
            //---------------------------
            var androidSettings = pushSettings.Where(s => s.NotificationFor.ToLower() == "android").ToList();
            if (androidSettings.Count > 0 && androidSettings != null)
            {
                var androidSetting = androidSettings.FirstOrDefault();
                push.RegisterGcmService(new GcmPushChannelSettings(androidSetting.GoogleAPIKey));
                //Fluent construction of an Android GCM Notification
                //IMPORTANT: For Android you MUST use your own RegistrationId here that gets generated within your Android app itself!
                push.QueueNotification(new GcmNotification().ForDeviceRegistrationId(androidSetting.DeviceToken)
                                                 .WithJson("{\"alert\":\"New campaign available\",\"badge\":" + androidSetting.Badge +",\"sound\":\"" + androidSetting.Sound +"\"}"));
            }

            //Stop and wait for the queues to drains
            push.StopAllServices();
        }

        static void DeviceSubscriptionChanged(object sender, string oldSubscriptionId, string newSubscriptionId, INotification notification)
        {
            //Currently this event will only ever happen for Android GCM
            logging.Info("Device Registration Changed:  Old-> " + oldSubscriptionId + "  New-> " + newSubscriptionId + " -> " + notification);
        }

        static void NotificationSent(object sender, INotification notification)
        {
            logging.Info("Sent: " + sender + " -> " + notification);
        }

        static void NotificationFailed(object sender, INotification notification, Exception notificationFailureException)
        {
            logging.Error(notificationFailureException.ToString());
        }

        static void ChannelException(object sender, IPushChannel channel, Exception exception)
        {
            logging.Error(exception.ToString());
        }

        static void ServiceException(object sender, Exception exception)
        {
            logging.Error(exception.ToString());
        }

        static void DeviceSubscriptionExpired(object sender, string expiredDeviceSubscriptionId, DateTime timestamp, INotification notification)
        {
            logging.Info("Device Subscription Expired: " + sender + " -> " + expiredDeviceSubscriptionId);
        }

        static void ChannelDestroyed(object sender)
        {
            Console.WriteLine("Channel Destroyed for: " + sender);
        }

        static void ChannelCreated(object sender, IPushChannel pushChannel)
        {
            logging.Info("Channel Created for: " + sender);
        }

    }
}
