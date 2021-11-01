﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tim_Xe.Service.NotificationService.Google
{
    public class FcmSettings
    {
        /// <summary>
        /// FCM Sender ID
        /// </summary>
        public string SenderId { get; set; }

        /// <summary>
        /// FCM Server Key
        /// </summary>
        public string ServerKey { get; set; }
    }
}