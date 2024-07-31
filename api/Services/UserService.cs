using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models.DTO;
using api.Services.Context;

namespace api.Services
{
    public class UserService
    {

        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        //helper functions to help us to check if the user exists
        //DoesUserExist
        public bool DoesUserExist(string username)
        {
            //check our table to see if the user name exist
            //if one item matches, our condition will be returned
            //if no matches then return null
            //if multiple match it will return an error
        }



        //adding user logic
        public bool AddUser(CreateAccountDTO userToAdd)
        {
           
        }
    }
}