﻿using Newtonsoft.Json;

namespace Infobip.Api.Client.WebRtc.Models
{
    /// <summary>
    /// Configuration used to enable Android push notifications.
    /// </summary>
    public class AndroidApplicationPushNotificationConfig
    {
        /// <summary>
        /// FCM Server Key used to enable Android push notifications.
        /// </summary>
        /// <value>FCM Server Key used to enable Android push notifications.</value>
        [JsonProperty("fcmServerKey")]
        public string FcmServerKey { get; set; }
        
    }
}