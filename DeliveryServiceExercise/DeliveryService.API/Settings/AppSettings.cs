﻿namespace DeliveryService.API.Settings
{
    public class AppSettings
    {
        public string JWTSecret { get; set; }

        public string JWTIssuer { get; set; }

        public string JWTAudience { get; set; }

        public int JWTExpiresInDays { get; set; }


        public int RedisKeyTimeToLiveInSeconds { get; set; }


        public string GraphDatabaseEndpoint { get; set; }

        public string GraphDatabaseLogin { get; set; }

        public string GraphDatabasePassword { get; set; }
    }
}
