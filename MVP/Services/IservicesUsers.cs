﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Services
{
  public interface IservicesUsers<TEntity>
  {
    IEnumerable<TEntity> GetAll();
    TEntity Get(int id);
    void Add(TEntity entity);
    void Change(TEntity dbEntity, TEntity entity);
    void Delete(TEntity entity);

  }
}
