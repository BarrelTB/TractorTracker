using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractorTracker.Application.DTOs;
using TractorTracker.Core.Models;
using TractorTracker.Core;

namespace TractorTracker.Application.Services.Interfaces
{
    public interface IUserService
    {
        public int Login(string username, string password);
        public UserDTO GetUserByUsername(string username);
        public UserDTO GetUserById(int id);
        public bool SetUserTimeZone(int id, TimeZoneInfo timeZoneInfo);
        public int CreateOrUpdateUser(UserDTO userDTO);
    }
}
