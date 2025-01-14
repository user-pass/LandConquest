﻿namespace LandConquestDB.Entities
{
    using System;
    public class ChatMessages
    {
        public string PlayerId { get; set; }        
        public string PlayerMessage { get; set; }
        public string PlayerTargetId { get; set; }        
        public DateTime MessageSentTime { get; set; }
        public string RoomId { get; set; }
        public string PlayerTargetName { get; set; }
        public string PlayerName { get; set; }
    }
}
