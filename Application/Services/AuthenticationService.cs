//using Application.Interfaces;
//using Application.Models.Request;
//using Domain.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Application.Services
//{
    
//    public class AuthenticationService : IAuthServiceCustom
//    {
//            private readonly IUserRepository _userRepository;
//            private readonly AuthenticationServiceOptions _options;
//            private readonly IOperationResultService _operationResultService;
//            public AuthenticationService(IUserRepository userRepository, AuthenticationServiceOptions options, IOperationResultService operationResultService)
//        {
//            _userRepository = userRepository;
//            _options = options;
//            _operationResultService = operationResultService;
//        }
//    }

//    public User ValidateUser(AuthenticationRequest authenticationRequest)
//    {
//        if (string.IsNullOrEmpty(authenticationRequest.UserName))
//    }
    

//    public class AuthenticationServiceOptions
//    {
//       public const string AuthenticationService = "AutenticationService";

//       public string Issuer { get; set; }
//       public string Audience { get; set; }
//       public string SecretForKey { get; set; }
//    }
//}
