﻿using System;

namespace Messenger.Domain
{
    public class Message : IMessage
    {
        public Guid MessageId { get; }
        public DateTime CreatedDate { get; }
        public Guid MessageCreator { get; }
        public String MessageText { get; set; }

        public Message(User user, String messageText)
        {
            if (user == null)
                throw new ArgumentNullException("The user does not exist!");
            if (messageText == "")
                throw new ArgumentNullException("Empty messages are prohibited!");
            
            MessageId = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            MessageCreator = user.UserId;
            MessageText = messageText;


        }
    }
}