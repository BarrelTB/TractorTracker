using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractorTracker.Application.DTOs;
using TractorTracker.Core;
using TractorTracker.Core.Models;

namespace TractorTracker.Application.Services
{
    public class UserService
    {
        private readonly CoreDbContext _coreDbContext;
        private readonly AutoMapper.Mapper _mapper;
        public UserDTO Login(string username, string password)
        {
            using (_coreDbContext)
            {
                var user = _coreDbContext.User.Where(u => u.UserName == username && u.Password == password && u.IsDeleted == false).First();
                return _mapper.Map<UserDTO>(user);
            }
        }
        public UserDTO GetUserByUsername(string username) 
        {
            using (_coreDbContext)
            {
                var user = _coreDbContext.User.Where(u => u.UserName == username).First();
                return _mapper.Map<UserDTO>(user);
            }
        }
        public UserDTO GetUserById(int id)
        {
            using (_coreDbContext)
            {
                var user = _coreDbContext.User.Find(id);
                return _mapper.Map<UserDTO>(user);
            }
        }
        public bool SetUserTimeZone(int id, TimeZoneInfo timeZoneInfo)
        {
            using (_coreDbContext)
            {
                try
                {
                    var user = _coreDbContext.User.Find(id);
                    user.TimeZoneInfo = timeZoneInfo.ToString();
                    _coreDbContext.SaveChanges();
                    return true;
                }
                catch(Exception ex) 
                {
                    return false;
                }
                
            }
        }

        public bool CreateOrUpdateUser(UserDTO userDTO)
        {
            using (_coreDbContext)
            {
                try
                {
                    var user = _coreDbContext.User.Find(userDTO.Id);
                    user = _mapper.Map<UserDTO, User>(userDTO);

                    _coreDbContext.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }
    }
}
