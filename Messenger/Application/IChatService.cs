﻿using System;
using System.Collections.Generic;
using Messenger.Domain;

namespace Messenger.Application
{
    public enum ChatType
    {
        Channel,
        Group,
        Private
    }
    public interface IChatService
    {
        IChat CreateChat(ChatType chatType, List<IUser> firstChatUsers, String chatName);

        void GetChat(Guid chatId);
        void DeleteChat(Guid chatId);
    }
}