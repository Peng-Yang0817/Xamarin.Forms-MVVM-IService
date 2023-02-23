﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MyAppMVVM.Models
{
    public class Favorite
    {
        // Attribute
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public bool IsFavorite { get; set; }
    }
}
