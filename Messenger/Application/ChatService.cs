﻿using System;
using System.Collections.Generic;
using Messenger.Domain;
using Messenger.Infrastructure;

namespace Messenger.Application
{
    public  abstract class ChatService : IChatService
    {
        private readonly IChatRepository _chatRepository;

        // создать где-то объект chat со всеми параметрами и сюда передать
        public abstract IChat CreateChat(ChatType chatType, List<IUser> firstChatUsers, String chatName);

        public void GetChat(Guid chatId)
        {
            _chatRepository.GetChat(chatId);
        }

        public void DeleteChat(Guid chatId)
        {
            _chatRepository.DeleteChat(chatId);
        }

        public ChatService(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }
    }
}