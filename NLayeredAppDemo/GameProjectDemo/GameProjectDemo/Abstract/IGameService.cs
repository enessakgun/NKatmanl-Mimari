﻿using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public interface IGameService
    {
        void Add (Game game);
        void Remove (Game game);
    }
}
