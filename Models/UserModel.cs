using System;

namespace coouncil.Models {
    public class UserModel {

        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string Role { get; set; }
    }
}