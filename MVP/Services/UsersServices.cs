using MVP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Services
{
  public class UsersServices : IservicesUsers<Users>
  {

    readonly DbContext dbContext;
    public UsersServices(DbContext context)
    {
      dbContext = context;
    }

    public IEnumerable<Users> GetAll()
    {
      throw new NotImplementedException();
    }
      public void Add(Users entity)
    {
      throw new NotImplementedException();
    }

    public void Change(Users dbEntity, Users entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(Users entity)
    {
      throw new NotImplementedException();
    }

    public Users Get(int id)
    {
      throw new NotImplementedException();
    }

 
  }
}
