using ChatApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Services
{
    public interface IMessageService
    {

         List<User> GetUsers();
         List<Message> GetChats();

         List<Message> GetMessages(User sender);
    }
}
