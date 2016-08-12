﻿using System;

namespace SonoPeople.Domain
{
    public class DomainObject
    {
        private bool _active = true;
        private DateTime _created = DateTime.Now;
        private string _id = Guid.NewGuid().ToString("D").ToUpper();
        private string _name = "";
        public const string CURRENT_DOMAIN_VERSION = "20150322";
        private string _version = CURRENT_DOMAIN_VERSION;

        /// <summary>
        /// The stored version at that time. Compare with
        /// DomainObject.CURRENT_DOMAIN_VERSION
        /// </summary>
        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }

        public DomainObject()
        {
        }

        public DomainObject(string name)
        {
            Name = name;
        }

        public DateTime Created
        {
            get { return _created; }
            set { _created = value; }
        }

        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }

        public bool Default { get; set; }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            return Name;
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == this) return true;
            var other = obj as DomainObject;
            if (other == null) return false;
            return _id == other.Id;
        }
    }
}
