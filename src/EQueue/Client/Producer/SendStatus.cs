﻿using System.Threading.Tasks;

namespace EQueue.Client.Producer
{
    public enum SendStatus
    {
        SEND_OK = 1,
        FLUSH_DISK_TIMEOUT
    }
}