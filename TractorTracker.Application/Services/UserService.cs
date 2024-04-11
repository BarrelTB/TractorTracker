using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TractorTracker.Application.DTOs;
using TractorTracker.Application.Services.Interfaces;
using TractorTracker.Core;
using TractorTracker.Core.Models;

namespace TractorTracker.Application.Services
{
    public class UserService : IUserService
    {
        private readonly CoreDbContext _coreDbContext;
        private readonly IMapper _mapper;

        public UserService(CoreDbContext coreDbContext, IMapper mapper)
        {
            _coreDbContext = coreDbContext;
            _mapper = mapper;
        }

        public int Login(string username, string password)
        {
            using (_coreDbContext)
            {
                var id = _coreDbContext.User.Where(u => u.UserName == username && u.Password == password && u.IsDeleted == false).First().Id;
                return id;
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
                    user.TimeZoneId = timeZoneInfo.Id;
                    _coreDbContext.SaveChanges();
                    return true;
                }
                catch(Exception ex) 
                {
                    return false;
                }
                
            }
        }

        public int CreateOrUpdateUser(UserDTO userDTO)
        {
            using (_coreDbContext)
            {
                try
                {
                    var user = _mapper.Map<UserDTO, User>(userDTO);
                    if (userDTO.Id <= 0)
                    {
                        _coreDbContext.User.Add(user);
                        _coreDbContext.SaveChanges();
                        return user.Id;
                    }
                    else
                    {
                        var oldUser = _coreDbContext.User.Find(userDTO.Id);
                        user.Id = oldUser.Id;
                        _coreDbContext.User.Update(user);
                        _coreDbContext.SaveChanges();
                        return user.Id;
                    }
                    
                }
                catch (Exception ex)
                {
                    return 0;
                }

            }
        }
    }
}
