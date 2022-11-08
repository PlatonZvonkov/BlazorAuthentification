namespace PasswordHash
{
    internal class TokenStorage
    {
        private string userToken = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiVG9ueSBTdGFyayIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IlVzZXIiLCJleHAiOjMxNjg1NDAwMDB9.dqS_eSZ7gba3erRDB0JFiHBx_LcYasdjZjz9pnkbsqUMFdEz-Ln8A28WsphH-TX6iVt2TUGQZO1HLSwYSsgBow";
        private string adminToken = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiQm9iIE1hcnRpbiIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IkFkbWluIiwiZXhwIjozMTY4NTQwMDAwfQ.38yerHIroKWFumHPZmmOvV1kHb7hzcT-unzRX3J4TpU1fc2Rt6rMoKPHbnqFAHn-YjTwYOCJ8KJFbvmuqMOS0Q";
        private string tonyStarkPasswordHash = "qwerty";
        private string bobMartinPasswordHash = "qwerty1";
        public string UserToken { get { return userToken; } }
        public string AdminToken { get { return adminToken; } }

        public string TonyStarkPasswordHash { get { return tonyStarkPasswordHash; } }
        public string BobMartinPasswordHash { get { return bobMartinPasswordHash; } }

    }
}
