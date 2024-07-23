﻿using Application.Common;
using Application.Interfaces;
using Application.Models;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IOperationResultService _operationResultService;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IOperationResultService operationResultService, IMapper mapper)
        {
            _userRepository = userRepository;
            _operationResultService = operationResultService;
            _mapper = mapper;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public OperationResult CreateClient(ClientDto clientDto)
        {
            if (!ValidatePassword(clientDto.Password)) {
                {
                    return _operationResultService.CreateFailResult("");
                }
                var newClient =_mapper.Map<Client>(clientDto);
                _userRepository.CreateClient(newClient);
                _userRepository.SaveChanges();
                return _operationResultService.CreateSuccessResult("client created")
        }

             static bool ValidatePassword(string password)
            {
                if (password.Contains("")) { return false; }
                if (password.Length <= 4 || password.Length >= 10) { return false; }
                if (!Regex.IsMatch(password, "[A-Z]")) { return false; }
                if (!Regex.IsMatch(password, "[a-z]")) { return false; }
                if (!Regex.IsMatch(password, "[!@#$%^&*(),.?\":{}|<>]")) { return false; }
                if (!Regex.IsMatch(password, "[0-9]")) { return false; }
                return true;
            }

        }

    }
}
