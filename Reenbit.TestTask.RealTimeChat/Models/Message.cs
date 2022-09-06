﻿using System;
using System.Collections.Generic;

namespace Reenbit.TestTask.RealTimeChat.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public string? TextMessage { get; set; }
        public DateTime? DateMessage { get; set; }
        public int? UserId { get; set; }
        public int? RoomId { get; set; }

        public virtual Room? Room { get; set; }
        public virtual User? User { get; set; }
    }
}