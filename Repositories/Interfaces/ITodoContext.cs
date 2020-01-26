using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SolucionarApi.Models;
using TodoApi.Models;

namespace SolucionarApi.Repositories.Interfaces
{
    public interface ITodoContext : IBaseRepository
    {
        
        DbContextOptions<TodoContext>  TodoContext();
        
        
    }
}