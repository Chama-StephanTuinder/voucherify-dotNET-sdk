﻿using System;
using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class Customer
    { 
        [DataMember(Name = "id")]
        public string Id { get; private set; }

        [DataMember(Name = "source_id")]
        public string SourceId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [DataMember(Name = "metadata")]
        public Metadata Metadata { get; set; }

        [DataMember(Name = "object")]
        public string Object { get;  set; }

        public Customer()
        {
            this.Metadata = new Metadata();
        }
    }
}