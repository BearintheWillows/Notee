﻿namespace Notee.Data.Interfaces;

    public interface IHasTimestamps
    {
        public DateTime Added { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Deleted { get; set; }
    }

