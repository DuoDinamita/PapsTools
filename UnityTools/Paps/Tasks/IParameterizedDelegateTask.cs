﻿using System;

namespace Paps.Tasks
{
    public interface IParameterizedDelegateTask<Deleg> : IDelegateTask<Deleg> where Deleg : Delegate
    {
        void SetParams(params object[] parameters);
    }
}
