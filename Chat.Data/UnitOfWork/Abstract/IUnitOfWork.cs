using Chat.Data;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Data;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<User> UserRepository { get; }
    void Complete();
}