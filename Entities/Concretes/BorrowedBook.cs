﻿using Entities.Constract;
using System;

namespace Entities.Concretes
{
    public class BorrowedBook : IEntity
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }

    }
}