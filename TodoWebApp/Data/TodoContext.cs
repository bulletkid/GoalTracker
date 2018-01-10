﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoWebApp.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext (DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoWebApp.Models.Todo> Todo { get; set; }
    }
}
