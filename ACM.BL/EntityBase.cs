﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public bool IsNew { get; set; }
        public bool HasChanges { get; set; }
        public EntityStateOption EntityState { get; set; }
        public bool IsValid
        {
            get
            {
                return Validate();
            }
        }

        //abstract because base does not have own implementation
        // must be overridden by derived classes
        public abstract bool Validate();
    }
}
