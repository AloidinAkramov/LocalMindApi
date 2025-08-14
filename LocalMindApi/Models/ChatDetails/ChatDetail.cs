using LocalMindApi.Models.Chats;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LocalMindApi.Models.ChatDetails
{
    public class ChatDetail
    {
        public Guid Id { get; set; }
        public string Source { get; set; }
        public string Content { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public Guid ChatId { get; set; }
        public Chat chat { get; set; }


        public virtual ICollection<ChatDetail> ChatDetails { get; set; }
    }
}
